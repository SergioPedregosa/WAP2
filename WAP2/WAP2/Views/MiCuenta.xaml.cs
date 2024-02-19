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
    public partial class MiCuenta : ContentPage
    {
        public MiCuenta()
        {
            InitializeComponent();
        }
        private void Return(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Save(object sender, EventArgs e)
        {

        }
    }
}