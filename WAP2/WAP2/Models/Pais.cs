namespace WAP2.Models
{
    public class Pais
    {
        public string Nombre { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
