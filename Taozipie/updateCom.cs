using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taozipie
{
    public partial class updateCom : Form
    {
        public delegate void updateCommission(commission com);
        public delegate void deleteCommission(commission com);

        public delegate void uploadImage(savingImage img);
        public delegate void deleteImage(savingImage img);

        public updateCommission onUpdate;
        public deleteCommission onDelete;


        public uploadImage onUploadImage;
        public deleteImage onDeleteImage;

        private commission _commission;
        private List<Product> _products;
        private List<savingImage> tempUploadedImages;
        
        public updateCom(commission _commission, List<Product> products)
        {
            InitializeComponent();
            this._commission = _commission;
            this._products = products;

            unloadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            onDelete(_commission);
            MessageBox.Show("Deleted", "Deleted");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            passChanges();

            updateCommissionInfo();
            onUpdate(_commission);
            MessageBox.Show("Updated", "Updated");
            this.Close();
        }

        private void passChanges()
        {
            foreach (customListviewItemImages img in lvOriginal.Items)
            {
                if (img.fromStart && !img.comfirmed)
                {
                    onDeleteImage(img.image);
                }

                if (!img.fromStart && img.comfirmed)
                {
                    onUploadImage(img.image);
                }
            }

            foreach (customListviewItemImages img in lvFinished.Items)
            {
                if (img.fromStart && !img.comfirmed)
                {
                    onDeleteImage(img.image);
                }

                if (!img.fromStart && img.comfirmed)
                {
                    onUploadImage(img.image);
                }
            }
        }

        private void updateCommissionInfo()
        {
            _commission._setName(tbName.Text);
            _commission._setInstagram(tbInstagram.Text);
            _commission._setEmail( tbEmail.Text);
            _commission._setPaypal(tbPaypal.Text);
            _commission._setPayedAmmount(double.Parse(tbPayedAmmount.Text));
            _commission._setOrderTime(tbDate.Value);
            _commission._setDetails(tbDetails.Text);
            _commission._setFinishedTime(dateFinished.Value);
            _commission._setFinished(cbCommissionFinished.Checked);
            _commission._setProductID(((Taozipie.customComboBoxItem)tbProductType.SelectedItem).Value.ID);
        }

        private void unloadData()
        {
            tbName.Text = _commission.name;
            tbInstagram.Text = _commission.instagram;
            tbEmail.Text = _commission.email;
            tbPaypal.Text = _commission.paypal;
            tbPayedAmmount.Text = _commission.payedAmmount.ToString();
            tbDate.Value = _commission.orderTime;
            tbDetails.Text = _commission.details;
            pictureBox1.Image = _commission.image[0].image;

            cbCommissionFinished.Checked = _commission.finished;
            dateFinished.Value = _commission.finishedTime;

            //original images
            ImageList imgListOrg = new ImageList();
            imgListOrg.ImageSize = new Size(128,128);
            imgListOrg.ColorDepth = ColorDepth.Depth32Bit;
            foreach (savingImage img in _commission.image)
            {
                imgListOrg.Images.Add(img.ID.ToString(),img.image);
            }

            //finished images
            ImageList imgListFin = new ImageList();
            imgListFin.ImageSize = new Size(128, 128);
            imgListFin.ColorDepth = ColorDepth.Depth32Bit;
            foreach (savingImage img in _commission.imageFinished)
            {
                imgListFin.Images.Add(img.ID.ToString(), img.image);
            }

            //add to lists
            lvOriginal.LargeImageList = imgListOrg;
            lvFinished.LargeImageList = imgListFin;

            //org
            foreach (savingImage img in _commission.image)
            {
                customListviewItemImages temp = new customListviewItemImages(img, true, true);
                lvOriginal.Items.Add(temp);
            }

            //fin
            foreach (savingImage img in _commission.imageFinished)
            {
                customListviewItemImages temp = new customListviewItemImages(img, true, true);
                lvFinished.Items.Add(temp);
            }

            //product types
            foreach(Product product in _products)
            {
                customComboBoxItem temp = new customComboBoxItem();
                temp.Text = product.name;
                temp.Value = product;

                tbProductType.Items.Add(temp);
            }

            foreach(customComboBoxItem temp in tbProductType.Items)
            {
                if (temp.Value.ID == _commission.productID)
                    tbProductType.SelectedItem = temp;
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var contextMenu = menuItem.GetCurrentParent() as ContextMenuStrip;
            var lv = contextMenu.SourceControl as ListView;

            addImage(lv);
        }

        private void addImage(ListView lv)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);

                savingImage img = new savingImage();
                img._setImage(new Bitmap(File));
                img._setCustomerID(Convert.ToInt32(_commission.ID));
                if (lv == lvFinished)
                    img._setType(1);
                else img._setType(0);

                Random rand = new Random();
                string id= rand.Next() + "temp";
                lv.LargeImageList.Images.Add(id, img.image);


                customListviewItemImages temp = new customListviewItemImages(img, id, true, false);
                lv.Items.Add(temp);

                //onUploadImage(img);
            }
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var contextMenu = menuItem.GetCurrentParent() as ContextMenuStrip;
            var lv = contextMenu.SourceControl as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ((customListviewItemImages)lv.SelectedItems[0]).comfirmed = false;
                lv.SelectedItems[0].ForeColor = Color.Red;
            }
                

        }

        private void lvOriginal_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //cmsControlImages.Show();
            }
        }
    }
}
