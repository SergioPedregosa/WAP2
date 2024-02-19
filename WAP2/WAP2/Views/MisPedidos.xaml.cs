using WAP2.Models;
using WAP2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisPedidos : ContentPage
    {
        ProductService productService = new ProductService();
        public MisPedidos()
        {
            InitializeComponent();
            PedidosTemplate.ItemsSource = productService.participationList();
            
        }
        
    }
}