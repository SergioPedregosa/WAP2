using System.Threading.Tasks;
using WAP2.Models;
using WAP2.ViewModels;
using WAP2.Views;

namespace WAP2.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            var mainViewModel = MainViewModel.GetInstance();

            switch (pageName)
            {

                case "AddProducto":
                    mainViewModel.AddProducto = new AddProductoViewModel();
                    await App.Current.MainPage.Navigation.PushAsync(new AddProducto());
                    break;
                default:
                    break;
            }
        }
        public async Task EditProducto(Producto producto)
        {
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.EditProducto = new EditProductViewModel(producto);
            await App.Current.MainPage.Navigation.PushAsync(new EditProducto());
        }
        public async Task DetailsProduct(Producto producto)
        {
            var buscadorViewModel = BuscadorViewModel.GetInstance();
            buscadorViewModel.DetailsProduct = new DetailsProductViewModel(producto);
            await App.Current.MainPage.Navigation.PushAsync(new DetailsProduct());
        }
        public async Task DetailsParticipation(Participacion participacion)
        {
            var pedidosViewModel = PedidosViewModel.GetInstance();
            pedidosViewModel.DetailsParticipations = new DetailsParticipationViewModel(participacion);
            await App.Current.MainPage.Navigation.PushAsync(new DetailsParticipations());
        }
        public async Task DetailsAnuncio(Anuncio anuncio)
        {
            var pedidosViewModel = PedidosViewModel.GetInstance();
            pedidosViewModel.DetailsAnuncios = new DetailsAnuncioViewModel(anuncio);
            await App.Current.MainPage.Navigation.PushAsync(new DetailsAnuncio());
        }
        public async Task Back()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        public async Task BuyProduct()
        {
            //await App.Current.MainPage.Navigation.PushAsync(new ProductoSubido());
        }
    }
}
