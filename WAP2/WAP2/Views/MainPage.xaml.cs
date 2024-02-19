using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Implementar el login cuando se restaure AZURE      IMPORTANTE--------------------------
            Navigation.PushAsync(new Home());
        }
    }
}