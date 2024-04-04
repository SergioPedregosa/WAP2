using System.Drawing;
using WAP2.ViewModels;

namespace WAP2.Models
{
    public class Participacion : Producto
    {
        public Participacion() { }

        public Participacion(int participacionId, int numeroParticipaciones, string estado)
        {
            ParticipacionId = participacionId;
            NumeroParticipaciones = numeroParticipaciones;
            Estado = estado;
        }
        public Participacion(int participacionId, int numeroParticipaciones, string estado, Color frameColor, ProductItemViewModel producto)
        {
            ParticipacionId = participacionId;
            NumeroParticipaciones = numeroParticipaciones;
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
            TempBarValue = producto.TempBarValue;
        }

        public int ParticipacionId { get; set; }
        public int NumeroParticipaciones { get; set; }
        public string Estado { get; set; }
        public Color FrameColor { get; set; }


        public override int GetHashCode()
        {
            return ParticipacionId;
        }
    }
}
