using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Taozipie
{
    public class Product
    {
        public delegate void onSetProduct(Product product);
        public onSetProduct setProduct;
        
        //variables
        public string name { get; private set; }
        public int ID { get; private set; }


        //having information
        public Product(int ID, string name)
        {
            this.ID = ID;
            this.name = name;

            //return delegate
            if (setProduct != null)
                setProduct(this);
        }

        //with having ID
        public Product(int ID, SQLiteConnection con)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            string sql = $"SELECT * FROM Product WHERE ID = {ID}";
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                _setID((int)reader[0]);
                _setName((string)reader[1]);
            }
            con.Close();

            //return delegate
            if (setProduct != null)
                setProduct(this);
        }

        //empty
        public Product()
        {

        }


        //setters
        public void _setName(string name) { this.name = name; }
        public void _setID(int ID) { this.ID = ID; }
        public void _setProduct(int ID, string name) { this.ID = ID; this.name = name; if (setProduct != null) setProduct(this); }
    }
}
