using System;
using WAP2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DireccionEnvio : ContentPage
    {
        AddressViewModel addressViewModel = new AddressViewModel();
        public DireccionEnvio()
        {
            InitializeComponent();
            addressViewModel.Load();
        }

        private void navToCambiarDireccion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CambiarDireccionEnvio());
        }
        private void mostrarDirecciones()
        {
            //TODO: Mostrar o no imagen y texto de que no hay direciones añadidas
        }
    }
}