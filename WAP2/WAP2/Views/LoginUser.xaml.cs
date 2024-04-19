using System;
using WAP2.Resources.Repositories;
using WAP2.Services;
using Xamarin.Essentials;
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
            NavigationPage.SetHasBackButton(this, false);
            
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
                    Preferences.Set("token", token);
                    Preferences.Set("email", email);
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