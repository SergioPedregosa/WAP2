using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsProduct : ContentPage
    {
        public DetailsProduct()
        {
            InitializeComponent();

        }
        
        //Compartir la participación en redes sociales
        private void Share(object sender, EventArgs e)
        {

        }
        //Comprar la participación
        private void Buy(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ResumenCompra());
        }
        //Muestra un mensaje de ayuda
        private void ShowInfo(object sender, EventArgs e)
        {
            //TODO: Mensaje
        }
    }
}