using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Taozipie
{
    class customListViewItem : ListViewItem
    {
        public commission commission;

        public customListViewItem(commission com)
        {
            this.commission = com;
            base.Text = com.instagram;
            base.ImageKey = com.ID.ToString();
            if(!com.finished)
            {
                base.ForeColor = Color.Red;
            }
        }
    } 

    class customListviewItemImages :ListViewItem
    {
        public bool comfirmed = false;
        public bool fromStart = false;
        public savingImage image;

        public customListviewItemImages(savingImage img, bool com, bool fs)
        {
            this.image = img;
            base.Text = img.ID.ToString();
            base.ImageKey = img.ID.ToString();

            comfirmed = com;
            fromStart = fs;
        }

        public customListviewItemImages(savingImage img, string temp, bool com, bool fs)
        {
            this.image = img;
            base.Text = img.ID.ToString();
            base.ImageKey = temp;

            comfirmed = com;
            fromStart = fs;
        }


    }
}
