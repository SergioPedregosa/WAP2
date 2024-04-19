using System;
using WAP2.Resources.Repositories;
using WAP2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterUser : ContentPage
    {
        UserRepository userRepository = new UserRepository();
        DialogService dialogService = new DialogService();
        public RegisterUser()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        private void navToLogin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUser());
        }
        //Comprueba los datos del nuevo usuario y si son correctos lo registra en Firebase
        private async void Register(object sender, EventArgs e)
        {
            string name = RegisterName.Text;
            string email = RegisterEmail.Text;
            string password = RegisterPassword.Text;
            if (String.IsNullOrEmpty(name))
            {
                await dialogService.ShowMessage("Error", "Introduce un nombre de usuario");
                return;
            }
            if (String.IsNullOrEmpty(email))
            {
                await dialogService.ShowMessage("Error", "Introduce un correo");
                return;
            }
            if (password.Length < 6)
            {
                await dialogService.ShowMessage("Error", "La contraseña debe ser de 6 caracteres o mas");
                return;
            }
            try
            {
                bool isSave = await userRepository.Register(name, email, password);
                if (isSave)
                {
                    await dialogService.ShowMessage("Registro de usuario", "Registro completo");
                    await Navigation.PushAsync(new Home());
                }
                else
                {
                    await dialogService.ShowMessage("Registro de usuario", "Fallo al registrar usuario");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("EMAIL_EXISTS"))
                {
                    await dialogService.ShowMessage("Error al crear usuario","El correo utilizado ya existe");
                }
            }
        }
    }
}