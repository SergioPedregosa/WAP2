using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private ApiService apiService;
        private NavigationService navigationService;
        private DialogService dialogService;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ProductItemViewModel> Products { get; set; }
        public AddProductoViewModel AddProducto { get; set; }
        public EditProductViewModel EditProducto { get; set; }
        public bool IsRefreshing
        {
            set
            {
                if (isRefreshing != value)
                {
                    isRefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
                }
            }
            get
            {
                return isRefreshing;
            }
        }

        #endregion

        #region Constructors
        public MainViewModel()
        {
            //Singleton
            instance = this;

            //Services
            apiService = new ApiService();
            navigationService = new NavigationService();
            dialogService = new DialogService();

            //View Models
            Products = new ObservableCollection<ProductItemViewModel>();
        }
        #endregion

        #region Methods
        //Carga los productos de la base de datos
        private async void LoadProducts()
        {
            var response = await apiService.Get<Producto>("https://wapback.azurewebsites.net", "/api", "/Products");
            if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error", response.Message);
                return;
            }
            ReloadProducts((List<Producto>)response.Result);
        }
        //Refresca los productos
        private void ReloadProducts(List<Producto> productos)
        {
            Products.Clear();

            foreach (var product in productos)
            {
                Products.Add(new ProductItemViewModel
                {
                    ProductId = product.ProductId,
                    Description = product.Description,
                    Price = product.Price,
                    Name = product.Name,
                    Created = product.Created,
                    User_RID = product.User_RID,
                    Category = product.Category,
                    Subcategory = product.Subcategory,
                    Status = product.Status,
                    Image = product.Image
                });
            }

        }

        #endregion

        #region Commands
        public ICommand NavToAddProducto { get { return new RelayCommand(ToAddProducto); } }
        public ICommand RefreshProductsCommand { get { return new RelayCommand(RefreshProducts); } }
        private async void ToAddProducto()
        {
            await navigationService.Navigate("AddProducto");
        }
        private void RefreshProducts()
        {
            IsRefreshing = true;
            LoadProducts();
            IsRefreshing = false;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
