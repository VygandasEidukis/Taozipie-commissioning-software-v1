using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Taozipie
{
    public partial class formMain : Form
    {
        Database.database database = new Database.database();
        List<Product> products = new List<Product>();
        List<commission> commissions = new List<commission>();

        public formMain()
        {
            InitializeComponent();

            database.updateLists += databaseCallback;

            //get products
            getProducts();
            getCommissions();

            updateLists();
        }

        private void databaseCallback()
        {
            lv_All.Clear();
            lw_Ongoing.Clear();
            tbProductType = new ComboBox();

            getProducts();
            getCommissions();

            updateLists();
        }

        private bool formFilled()
        {
            if (tbName.Text != "" && tbInstagram.Text != "" && tbEmail.Text != "" && tbPaypal.Text != "" && tbPayedAmmount.Text != "" && pictureBox1.Image != null)
                return true;
            return false;
        }


        #region ---clear form
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear filled in commission?", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearForm();
            }
        }

        private void clearForm()
        {
            tbDate.ResetText();
            tbEmail.reset();
            tbName.reset();
            tbPayedAmmount.reset();
            tbPaypal.reset();
            tbDetails.reset();
            tbInstagram.reset();
            pictureBox1.Image = null;
        }
        #endregion

        #region ---Create commission

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save commission?", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(formFilled())
                {
                    createCommission();
                    clearForm();
                }
            }
        }

        private void createCommission()
        {
            savingImage img = new savingImage();
            Bitmap bit = new Bitmap(pictureBox1.Image);
            img._setImage(bit);
            List<savingImage> temp = new List<savingImage>();
            temp.Add(img);
            commission newcommission = new commission(tbName.Text, tbInstagram.Text, tbEmail.Text, tbPaypal.Text, ((customComboBoxItem)tbProductType.SelectedItem).Value, ((customComboBoxItem)tbProductType.SelectedItem).Value.ID, tbDate.Value.Date, tbDetails.Text, temp, double.Parse(tbPayedAmmount.Text));
            saveToDatabase(newcommission);

        }

        private void saveToDatabase(commission com)
        {
            database._createNewCommission(com);
        }

        #endregion

        #region ---Handle product list

        public void setProduct(Product product)
        {
            customComboBoxItem item = new customComboBoxItem();

            item.Text = product.name;
            item.Value = product;

            tbProductType.Items.Add(item);
            tbProductType.SelectedIndex = 0;

            products.Add(product);
        }

        #endregion

        #region --- handle commission lists

        private void updateLists()
        {
            lv_All.Items.Clear();
            lw_Ongoing.Items.Clear();
            ///set all images
            var imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            foreach (commission com in commissions)
            {
                imageList.Images.Add(com.ID.ToString(), com.image[0].image);
            }

            //use this list
            lv_All.LargeImageList = imageList;
            lw_Ongoing.LargeImageList = imageList;

            foreach(commission com in commissions)
            {
                customListViewItem temp = new customListViewItem(com);
                if (com.finished)
                    lv_All.Items.Add(temp);
                else
                {
                    lw_Ongoing.Items.Add(temp);

                    var temp1 = new customListViewItem(com);

                    lv_All.Items.Add(temp1);
                }
            }
        }

        #endregion

        #region get data
        public void getProducts()
        {
            if (database.dbConnection.State != ConnectionState.Open)
                database.dbConnection.Open();
            try
            {
                string sql = "SELECT * FROM Product";
                SQLiteCommand command = new SQLiteCommand(sql, database.dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.setProduct += setProduct;
                    product._setProduct(Int32.Parse(reader[0].ToString()), (string)reader[1]);
                }

            }
            catch
            {
                throw new Exception("failed getting products");
            }
            finally
            {
                if (database.dbConnection.State != ConnectionState.Closed)
                    database.dbConnection.Close();
            }
        }


        private void getCommissions()
        {
            commissions = new List<commission>();
            commissions = database._readCommissions();
        }

        #endregion

        #region ---update Data

        public void deleteCommission(commission _com)
        {
            database._deleteCommission(_com);
        }

        public void updateCommission(commission _com)
        {
            database.updateCommission(_com);
        }

        #endregion


        #region --- form controls

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
            }
        }

        #endregion


        #region -- list communication

        private void lv_All_DoubleClick(object sender, EventArgs e)
        {
            loadUpdateForm(sender as ListView);
        }

        private void lw_Ongoing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadUpdateForm(sender as ListView);
        }

        private void loadUpdateForm(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                updateCom temp = new updateCom(((customListViewItem)lv.SelectedItems[0]).commission, products);
                temp.onUpdate += updateCommission;
                temp.onDeleteImage += removeImage;
                temp.onUploadImage += addImage;
                temp.onDelete += deleteCommission;
                temp.ShowDialog();

                getCommissions();
                updateLists();
            }
        }

        public void removeImage(savingImage img)
        {
            database._removeImage(img);
        }

        public void addImage(savingImage img)
        {
            database._addNewImage(img);
        }



        #endregion

        
    }
}
