using System;
using WAP2.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuracion : ContentPage
    {
        public Configuracion()
        {
            InitializeComponent();
            switch (Settings.Theme)
            {
                case 0:
                    SwitchDarkMode.IsToggled = false;
                    break;
                case 1:
                    SwitchDarkMode.IsToggled = true;
                    break;
            }
        }

        private void navToEditarPerfil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MiCuenta());
        }

        private void navToVerificacionYSeguridad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerificacionYSeguridad());
        }

        private void navToDireccionDeEnvio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DireccionEnvio());
        }

        private void navToNotificaciones(object sender, EventArgs e)
        {

        }

        private void navToEliminarCuenta(object sender, EventArgs e)
        {

        }

        private void DarkMode(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Settings.Theme = 1;
            }
            else
            {
                Settings.Theme = 0;
            }
            TheTheme.SetTheme();
        }
    }
}