using Azure.Identity;
using Microsoft.Graph;
using System;
using System.Threading.Tasks;
using WAP2.Services;
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

            //DisplayAlert("Test",UserID.Text,"Ok");
            //getUserByID(UserID.Text);

        }
        //Busca el nombre de usuario por oid
        /*public static async Task getUserByID(string id)
        {
            DialogService dialogService = new DialogService();

            try
            {
                var scopes = new[] { "https://graph.microsoft.com/.default" };
                var options = new ClientSecretCredentialOptions
                {
                    AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                };

                var clientSecretCredential = new ClientSecretCredential(
                    Models.Constants.TenantId, Models.Constants.ClientId, Models.Constants.ClientSecret, options);

                var graphClient = new GraphServiceClient(clientSecretCredential, scopes);
                var result = UsersService.GetUserByID(graphClient, id);
            }
            catch (Exception ex)
            {
                await dialogService.ShowMessage("Error", ex.Message);
            }
        }*/
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