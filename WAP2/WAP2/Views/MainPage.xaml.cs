using FirebaseAdmin;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void navToLogin(object sender, EventArgs e)
        {
            bool HasKey = Preferences.ContainsKey("token");
            if (HasKey)
            {
                string token = Preferences.Get("token", "");
                if (!string.IsNullOrEmpty(token))
                {
                    Navigation.PushAsync(new Home());
                }
            }
            else
            {
            Navigation.PushAsync(new LoginUser());
            }
        }
    }
}