using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Taozipie
{
    public class commission
    {
        public int? ID { get; private set; }
        public string name { get; private set; }
        public string instagram { get; private set; }
        public string email { get; private set; }
        public string paypal { get; private set; }
        public Product product { get; private set; }
        public int productID { get; private set; }
        public DateTime orderTime { get; private set; }
        public DateTime finishedTime { get; private set; }
        public string details { get; private set; }
        public List<savingImage> image { get; private set; }
        public List<savingImage> imageFinished { get; private set; }
        public double payedAmmount { get; private set; }
        public bool finished { get; set; }

        //Finished commission from database
        public commission(int ID, string name, string instagram, string email, string paypal, int product, DateTime orderTime, DateTime finishedTime, string details, List<savingImage> image, List<savingImage> imageFinished, double pA, bool cFinished)
        {
            this.ID = ID;
            this.name = name;
            this.instagram = instagram;
            this.email = email;
            this.paypal = paypal;
            this.productID = product;
            this.orderTime = orderTime;
            this.finishedTime = finishedTime;
            this.details = details;
            this.image = image;
            this.imageFinished = imageFinished;
            this.payedAmmount = pA;
            this.finished = cFinished;
        }

        //New commission
        public commission(string name, string instagram, string email, string paypal, Product productItem, int product, DateTime orderTime, string details, List<savingImage> image, double pA)
        {
            this.ID = null;
            this.name = name;
            this.instagram = instagram;
            this.email = email;
            this.paypal = paypal;
            this.product = productItem;
            this.productID = product;
            this.orderTime = orderTime;
            this.details = details;
            this.image = image;
            this.payedAmmount = pA;
        }

        //setters
        public void _setName(string name) { this.name = name; }
        public void _setInstagram(string instagram) { this.instagram = instagram; }
        public void _setEmail(string email) { this.email = email; }
        public void _setPaypal(string paypal) { this.paypal = paypal; }
        public void _setProduct(Product product) { this.product = product; }
        public void _setOrderTime(DateTime orderTime) { this.orderTime = orderTime; }
        public void _setDetails(string details) { this.details = details; }
        public void _setImage(List<savingImage> image) { this.image = image; }
        public void _setPayedAmmount(double payedAmmount) { this.payedAmmount = payedAmmount; }
        public void _setProductID(int i) { this.productID = i; }
        public void _setFinished(bool t) { this.finished = t; }
        
        //additional setters
        public void _setID(int ID) { this.ID = ID; }
        public void _setFinishedTime(DateTime finishedTime) { this.finishedTime = finishedTime; }
        public void _setImageFinished(List<savingImage> imageFinished) { this.imageFinished = imageFinished; }

        //Get commission

    }
}
