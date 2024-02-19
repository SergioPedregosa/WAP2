using System;

namespace WAP2.Models
{
    public class Producto
    {
        public Producto()
        {

        }
        public Producto(int ProductId, string Name, string Description, decimal Price, int Tokens, int PriceToken, DateTime Created, string Category, string Status, string image, int TempBarValue, string User_RID)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Created = Created;
            this.Category = Category;
            this.Status = Status;
            Image = image;
            this.TempBarValue = TempBarValue;
            this.User_RID = User_RID;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DateLimit { get; set; }
        public string User_RID { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public byte[] ImageArray { get; set; }
        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(Image))
                {
                    return "image_placeholder.png";
                }
                return string.Format("https://wapback.azurewebsites.net{0}", Image.Substring(1));
            }
        }
        public int TempBarValue { get; set; }

        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
