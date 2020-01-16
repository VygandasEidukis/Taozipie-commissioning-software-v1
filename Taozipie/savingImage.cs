using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Taozipie
{
    public class savingImage
    {
        public int ID { get; private set; }
        public int Customer_ID { get; private set; }
        public bool type { get; private set; }

        public Bitmap image;

        public savingImage(int ID, Bitmap image, int customerID)
        {
            this.image = image;
            this.ID = ID;
            this.Customer_ID = customerID;
        }

        public savingImage() { }

        public void _setID(int ID) { this.ID = ID; }
        public void _setImage(Bitmap img) { this.image = img; }
        public void _setCustomerID(int id) { this.Customer_ID = id; }
        public void _setType(int t) { type = Convert.ToBoolean(t); }
        
        public byte[] returnImageBytes(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static byte[] returnImageBytes2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public  Bitmap convertBytesToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }
    }

}
