using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAP2.Resources.Repositories;
using WAP2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUser : ContentPage
    {
        UserRepository userRepository = new UserRepository();
        DialogService dialogService = new DialogService();
        public LoginUser()
        {
            InitializeComponent();
        }

        private void navToRegister(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterUser());
        }
        //Inicia sesión con el usuario introducido
        private async void Login(object sender, EventArgs e)
        {
            try
            {
                string email = LoginEmail.Text;
                string password = LoginPassword.Text;
                string token = await userRepository.Login(email, password);
                if (!string.IsNullOrEmpty(token))
                {
                    await Navigation.PushAsync(new Home());
                }
                else
                {
                    await dialogService.ShowMessage("Error", "Error al iniciar sesión");
                }
            } catch (Exception ex)
            {
                await dialogService.ShowMessage("Fallo al iniciar sesión", ex.Message);
            }
        }
    }
}