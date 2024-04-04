using System;

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
            //TODO: Implementar el login de Firebase
            Navigation.PushAsync(new Home());
        }
    }
}