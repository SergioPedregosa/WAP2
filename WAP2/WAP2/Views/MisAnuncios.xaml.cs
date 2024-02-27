using WAP2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisAnuncios : ContentPage
    {
        ProductService productService = new ProductService();
        public MisAnuncios()
        {
            InitializeComponent();
            AnunciosTemplate.ItemsSource = productService.AnuncioList();
        }
    }
}