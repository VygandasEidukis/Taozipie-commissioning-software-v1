using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Taozipie.Database
{
    class database
    {
        //delegate
        public delegate void onUpdateDatabase();
        public onUpdateDatabase updateLists;

        //path to database
        private string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Database\taozipieMainDatabase.db";
        public SQLiteConnection dbConnection;
        public database()
        {
            path = path.Substring(6);
            dbConnection = new SQLiteConnection(@"Data Source=" + path);
        }

        #region //helpful commands

        private int lastInsertedPK()
        {
            if (dbConnection.State != System.Data.ConnectionState.Open)
                throw new Exception("error on no database is open lastInsertPK() // database.cs");

            string sql = "SELECT last_insert_rowid();";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                return int.Parse(reader[0].ToString());
            return 0;
        }

        #endregion

        #region --- Write ---

        public void _createNewCommission(commission com)
        {
            try
            {
                string sql = "INSERT INTO Customer (name, instagram, email, paypal, product_ID, Purchase_Date, Details, payedAmmount)" +
                              " VALUES(@name, @instagram, @email, @paypal, @product_ID, @Purchase_Date, @Details, @payedAmmount);";
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@name", com.name);
                cmd.Parameters.AddWithValue("@instagram", com.instagram);
                cmd.Parameters.AddWithValue("@email", com.email);
                cmd.Parameters.AddWithValue("@paypal", com.paypal);
                cmd.Parameters.AddWithValue("@product_ID", com.product.ID);
                cmd.Parameters.AddWithValue("@Purchase_Date", com.orderTime.ToShortDateString());
                cmd.Parameters.AddWithValue("@Details", com.details);
                cmd.Parameters.AddWithValue("@payedAmmount", com.payedAmmount);

                if (dbConnection.State != System.Data.ConnectionState.Open)
                    dbConnection.Open();
                cmd.ExecuteNonQuery();
                _createNewImage(com.image, null, false); //possition matters

                if(dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();
                
            }
            catch
            {
                throw new Exception("Failed saving data in database.cs");
            }
            finally
            {
                if (dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();

                updateLists?.Invoke();
            }
        }

        public void _createNewImage(List<savingImage> com, int? commissionID, bool type)
        {
            int? lastInsert;
            if (commissionID == null)
            {
                lastInsert = lastInsertedPK();
            } else lastInsert = commissionID;
            try
            {
                string sql = "INSERT INTO image (image, customer_ID, type)" +
                              " VALUES(@image, @customer_ID, @type);";
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                cmd.CommandType = System.Data.CommandType.Text;
                foreach (savingImage a in com)
                {
                    cmd.Parameters.AddWithValue("@image", a.returnImageBytes(a.image));
                    cmd.Parameters.AddWithValue("@customer_ID", lastInsert);
                    cmd.Parameters.AddWithValue("@type", Convert.ToInt32(type));
                    if (dbConnection.State != System.Data.ConnectionState.Open)
                        dbConnection.Open();
                    cmd.ExecuteNonQueryAsync();
                }
            }
            catch
            {
                throw new Exception("Failed saving data in database.cs");
            }
            finally
            {
                if (dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();
            }
        }
        
        public void _addNewImage(savingImage img)
        {
            try
            {
                string sql = "INSERT INTO image (image, customer_ID, type)" +
                              " VALUES(@image, @customer_ID, @type);";
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                cmd.CommandType = System.Data.CommandType.Text;
               
                cmd.Parameters.AddWithValue("@image", img.returnImageBytes(img.image));
                cmd.Parameters.AddWithValue("@customer_ID", img.Customer_ID);
                cmd.Parameters.AddWithValue("@type", img.type);
                if (dbConnection.State != System.Data.ConnectionState.Open)
                    dbConnection.Open();
                cmd.ExecuteNonQueryAsync();
            }
            catch
            {
                throw new Exception("Failed saving data in database.cs");
            }
            finally
            {
                if (dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();
            }
        }

        public void _removeImage(savingImage img)
        {
            try
            {
                string sql = $"DELETE FROM image WHERE ID={img.ID}";
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                if (dbConnection.State != System.Data.ConnectionState.Open)
                    dbConnection.Open();
                cmd.ExecuteNonQueryAsync();
            }
            catch
            {
                throw new Exception("Failed saving data in database.cs");
            }
            finally
            {
                if (dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();
            }
        }
        #endregion

        #region --- Read ---

        public List<commission> _readCommissions()
        {
            List<commission> coms = new List<commission>();
            try
            {
                string sql = "select * from Customer";
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                if (dbConnection.State != System.Data.ConnectionState.Open)
                    dbConnection.Open();
                //read data
                SQLiteDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    //connect
                    if (dbConnection.State != System.Data.ConnectionState.Open)
                        dbConnection.Open();
                    //
                    int IDs = int.Parse(reader[0].ToString());
                    string name = reader[1].ToString();
                    string instagram = reader[2].ToString();
                    string email = reader[3].ToString();
                    string paypal = reader[4].ToString();
                    int productID = int.Parse(reader[5].ToString());
                    DateTime purchaseDate = DateTime.Parse(reader[6].ToString());
                    DateTime finishDate = new DateTime();
                    try
                    { finishDate = DateTime.Parse(reader[7].ToString());}
                    catch { finishDate = DateTime.Today; }
                    string details = reader[8].ToString();
                    double payedAmmount = double.Parse(reader[9].ToString());
                    bool finished = Convert.ToBoolean(int.Parse(reader[10].ToString()));
                    List<savingImage> images = getImages(IDs, false);
                    List<savingImage> finishedImages = getImages(IDs, true);
                    commission temp = new commission(IDs, name, instagram, email, paypal, productID, purchaseDate, finishDate, details, images, finishedImages, payedAmmount, finished);
                    coms.Add(temp);
                }
            }
            catch
            {
                throw new Exception("error on _readCommission() Database");
            }
            finally
            {
                if (dbConnection.State != System.Data.ConnectionState.Closed)
                    dbConnection.Close();
            }
            return coms;
        }

        private List<savingImage> getImages(int customerID, bool type)
        {
            List<savingImage> imageList = new List<savingImage>();
            string sql = $"SELECT * FROM image WHERE customer_ID = {customerID};";
            if (dbConnection.State != System.Data.ConnectionState.Open)
                dbConnection.Open();

            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                savingImage temp = new savingImage();
                temp._setID(int.Parse(reader[0].ToString()));
                temp._setImage(temp.convertBytesToImage((byte[])reader[1]));
                temp._setCustomerID(int.Parse(reader[2].ToString()));
                temp._setType(int.Parse(reader[3].ToString()));
                if(type == temp.type)
                    imageList.Add(temp);
            }

            return imageList;

        }

        #endregion

        #region --- update ---

        public void updateCommission(commission com)
        {
            string sql = $"UPDATE Customer SET name=@name, instagram=@instagram, email=@email, paypal=@paypal, product_ID=@product_ID, Purchase_Date=@Purchase_Date, dateFinished=@dateFinished, Details=@Details, payedAmmount=@payedAmmount, finished=@finished WHERE ID={com.ID}";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@name", com.name);
            cmd.Parameters.AddWithValue("@instagram", com.instagram);
            cmd.Parameters.AddWithValue("@email", com.email);
            cmd.Parameters.AddWithValue("@paypal", com.paypal);
            cmd.Parameters.AddWithValue("@product_ID", com.productID);
            cmd.Parameters.AddWithValue("@Purchase_Date", com.orderTime.ToShortDateString());
            cmd.Parameters.AddWithValue("@dateFinished", com.finishedTime.ToShortDateString());
            cmd.Parameters.AddWithValue("@Details", com.details);
            cmd.Parameters.AddWithValue("@payedAmmount", com.payedAmmount);
            cmd.Parameters.AddWithValue("@finished", Convert.ToInt32(com.finished));

            if (dbConnection.State != System.Data.ConnectionState.Open)
                dbConnection.Open();
            cmd.ExecuteNonQuery();

            if (dbConnection.State != System.Data.ConnectionState.Closed)
                dbConnection.Close();
        }
        #endregion

        #region --- Delete ---

        public void _deleteCommission(commission com)
        {
            string sql = $"DELETE FROM Customer where ID={com.ID}";
            SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
            if (dbConnection.State != System.Data.ConnectionState.Open)
                dbConnection.Open();
            cmd.ExecuteNonQuery();

            sql = $"DELETE FROM image where customer_ID={com.ID}";
            cmd = new SQLiteCommand(sql, dbConnection);
            if (dbConnection.State != System.Data.ConnectionState.Open)
                dbConnection.Open();
            cmd.ExecuteNonQuery();

            if (dbConnection.State != System.Data.ConnectionState.Closed)
                dbConnection.Close();
        }

        #endregion
    }
}
