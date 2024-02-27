using WAP2.ViewModels;
using Xamarin.Forms;

namespace WAP2.Models
{
    public class Anuncio : Producto
    {
        public Anuncio()
        {
            
        }
        public Anuncio(int anuncioId, string estado, Color frameColor)
        {
            AnuncioId = anuncioId;
            Estado = estado;
            FrameColor = frameColor;
        }
        public Anuncio(int anuncioId, string estado, Color frameColor, ProductItemViewModel producto)
        {
            AnuncioId = anuncioId;
            Estado = estado;
            FrameColor = frameColor;
            ProductId = producto.ProductId;
            Name = producto.Name;
            Description = producto.Description;
            Price = producto.Price;
            Created = producto.Created;
            DateLimit = producto.DateLimit;
            User_RID = producto.User_RID;
            Category = producto.Category;
            Subcategory = producto.Subcategory;
            Status = producto.Status;
            Image = producto.Image;
            ImageArray = producto.ImageArray;
            TempBarValue = producto.TempBarValue;
        }
        public int AnuncioId { get; set; }
        public string Estado { get; set; }
        public Color FrameColor { get; set; }
    }
}