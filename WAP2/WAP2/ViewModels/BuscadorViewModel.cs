using CommunityToolkit.Mvvm.Input;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Resources.Repositories;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class BuscadorViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private NavigationService navigationService;
        private DialogService dialogService;
        private ProductRepository productRepository;
        private bool isRefreshing;
        private string palabraClave, categoria, subcategoria;
        private int productCount = 0;
        #endregion
        #region Properties
        public ObservableCollection<ProductItemViewModel> Products { get; set; }
        public DetailsProductViewModel DetailsProduct { get; set; }
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

        public BuscadorViewModel()
        {
            //Singleton
            instance = this;
            //Services
            navigationService = new NavigationService();
            dialogService = new DialogService();
            productRepository = new ProductRepository();
            //ViewModels
            Products = new ObservableCollection<ProductItemViewModel>();
        }
        #endregion
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Methods
        //Cargar productos de la base de datos
        private async void LoadProducts()
        {
            //Comando Firebase
            var response = await productRepository.GetAll();
            if (response.IsNullOrEmpty())
            {
                await dialogService.ShowMessage("Error", "No se han encontrado productos");
            }
            FilterProducts(response);

        }
        //Filtrar productos por categoria
        public void FilterProducts(List<Producto> productos)
        {
            Products.Clear();
            productCount = 0;
            foreach (var product in productos)
            {
                Products.Add(new ProductItemViewModel
                {
                    ProductId = product.ProductId,
                    Description = product.Description,
                    Price = product.Price,
                    Name = product.Name,
                    Created = product.Created,
                    Category = product.Category,
                    Subcategory = product.Subcategory,
                    Status = product.Status,
                    Image = product.Image,
                    TempBarValue = product.TempBarValue,
                    User_RID = product.User_RID
                });
                productCount++;
            }

        }
        //Obtener los datos para poder filtrar
        public void ObtenerDatos(string palabraClave, string categoria, string subcategoria)
        {
            this.palabraClave = palabraClave;
            this.categoria = categoria;
            this.subcategoria = subcategoria;
        }
        //Cuenta la cantidad de productos mostrados por el filtro
        public string ProductsCount()
        {
            return productCount.ToString();
        }
        public void Load()
        {
            LoadProducts();
        }
        #endregion
        #region Command
        public ICommand RefreshProductsCommand { get { return new RelayCommand(RefreshProducts); } }
        private void RefreshProducts()
        {
            IsRefreshing = true;
            LoadProducts();
            IsRefreshing = false;
        }
        #endregion
        #region Singleton
        private static BuscadorViewModel instance;
        public static BuscadorViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new BuscadorViewModel();
            }
            return instance;
        }
        #endregion
    }
}
