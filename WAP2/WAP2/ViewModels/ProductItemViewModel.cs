using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class ProductItemViewModel : Producto
    {
        private NavigationService navigationService;
        public ProductItemViewModel()
        {
            navigationService = new NavigationService();
        }
        public ICommand EditProductoCommand { get { return new RelayCommand(EditProducto); } }
        public ICommand DetailsProductoCommand { get { return new RelayCommand(DetailsProduct); } }

        private async void EditProducto()
        {
            await navigationService.EditProducto(this);
        }
        private async void DetailsProduct()
        {
            await navigationService.DetailsProduct(this);
        }
    }
}
