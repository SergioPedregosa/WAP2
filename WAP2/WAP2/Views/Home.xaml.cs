using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            //this.BindingContext = this;
            //CategoriasCarouselHome.ItemsSource = pickerService.CategoriasCorouselRows();
            //GetClaims();
            //var mainViewModel = MainViewModel.GetInstance();
            //base.Appearing += (object sender, EventArgs e) =>
            /**{
                mainViewModel.RefreshProductsCommand.Execute(this);
            };**/
        }
        private void GetClaims()
        {
            //Descomentar cuando se vuelva a activar Azure     IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /**var token = Transporter.authenticationResult.IdToken;
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var data = handler.ReadJwtToken(token);
                var claims = data.Claims.ToList();
                if (data != null)
                {
                    UsernameTest.Text = $"{data.Claims.FirstOrDefault(x => x.Type.Equals("name")).Value}";

                }
            }**/
        }
        private void ShowPopUp(object sender, EventArgs e)
        {
            //PopupNavigation.Instance.PushAsync(new PopUpSeleccionVentaRifa());
        }

        private void navToConfiguracion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Configuracion());
        }

        private void navToMisPedidos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisPedidos());
        }

        private void navToMisAnuncios(object sender, EventArgs e)
        {
        }
        //Provisional
        private void navToBuscador(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuscadorProducto());
        }
    }
}