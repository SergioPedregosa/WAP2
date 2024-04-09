using System;
using System.Collections.Generic;
using WAP2.Models;
using WAP2.Resources.Repositories;
using WAP2.Services;
using WAP2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        PickerService pickerService;
        BuscadorViewModel buscadorViewModel;
        //TEMPORAL
        ProductService productService;
        ProductRepository productRepository = new ProductRepository();
        List<Producto> productoList = new List<Producto>();
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            //HOME

            //BUSCADOR

            buscadorViewModel = BuscadorViewModel.GetInstance();
            productService = new ProductService();

            pickerService = new PickerService();

            buscadorViewModel.Load();
            productoList = productService.MountList();
            favoritesTemplate.ItemsSource = productoList;
        }
        #region Home
        
        private void ShowPopUp(object sender, EventArgs e)
        {
            //PopupNavigation.Instance.PushAsync(new PopUpSeleccionVentaRifa());
        }

        private void navToConfiguracion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Configuracion());
        }

        private void navToMisPedidos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisPedidos());
        }

        private void navToMisAnuncios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisAnuncios());
        }
        //Provisional
        private void navToBuscador(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BuscadorProducto());
        }
        #endregion
        #region Buscador
        //Carga una lista de subcategorias al picker de subcategorias en función de la categoria selecionada
        private void PickerCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**if (PickerSubcategoria.ItemsSource != null)
            {
                PickerSubcategoria.ItemsSource.Clear();
            }
            PickerSubcategoria.ItemsSource = pickerService.subcategoryPickerList(PickerCategoria.SelectedItem.ToString());**/
        }
        //Busca productos segun los criterios establecidos
        private async void Busqueda(object senderB, EventArgs ev)
        {
            string searchValue = TxtSearch.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var products = await productRepository.GetAllByName(searchValue);
                ProductTemplate.ItemsSource = null;
                ProductTemplate.ItemsSource = products;
            }
            else
            {
                OnAppearing();
            }
        }
        private async void TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchValue = TxtSearch.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var products = await productRepository.GetAllByName(searchValue);
                ProductTemplate.ItemsSource = null;
                ProductTemplate.ItemsSource = products;
            }
            else
            {
                OnAppearing();
            }
        }
        //Devuelve al usuario al menu de busqueda
        #endregion
        #region favoritos

        #endregion
        #region chat

        #endregion
        #region addProduct

        #endregion
        protected override async void OnAppearing()
        {
            buscadorViewModel.Load();
            ProductTemplate.ItemsSource = null;
            ProductTemplate.ItemsSource = buscadorViewModel.Products;
        }
    }
}