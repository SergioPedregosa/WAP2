using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using WAP2.Models;
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
        List<Producto> productoList = new List<Producto>();
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            //HOME
            //this.BindingContext = this;
            //CategoriasCarouselHome.ItemsSource = pickerService.CategoriasCorouselRows();
            //GetClaims();
            //var mainViewModel = MainViewModel.GetInstance();
            //base.Appearing += (object sender, EventArgs e) =>
            /**{
                mainViewModel.RefreshProductsCommand.Execute(this);
            };**/

            //BUSCADOR

            buscadorViewModel = BuscadorViewModel.GetInstance();
            productService = new ProductService();

            pickerService = new PickerService();

            productoList = productService.mountList();
            ProductTemplate.ItemsSource = productoList;
            favoritesTemplate.ItemsSource = productoList;
        }
        #region Home
        private void GetClaims()
        {
            //Descomentar cuando se vuelva a activar Azure     IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /**var token = Transporter.authenticationResult.IdToken;
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var data = handler.ReadJwtToken(token);
                var claims = data.Claims.ToList();
                if (data != null)
                {
                    UsernameTest.Text = $"{data.Claims.FirstOrDefault(x => x.Type.Equals("name")).Value}";

                }
            }**/
        }
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
        private void Busqueda(object senderB, EventArgs ev)
        {
            //if (PickerCategoria.SelectedItem.ToString() != string.Empty) {
            /**buscadorViewModel.ObtenerDatos("",PickerCategoria.SelectedItem.ToString(),PickerSubcategoria.SelectedItem.ToString());
            buscadorViewModel.RefreshProductsCommand.Execute(this);
            Filtro.IsVisible = false;
            ProductosBuscados.IsVisible = true;
            CountProducts.Text = buscadorViewModel.ProductsCount() + " productos";
            TextCategory.Text = "\"" + PickerSubcategoria.SelectedItem.ToString() + "\"";
            **/

            //TEMPORAL _________________________________________________-----------------------

            /**} else
            {
                DisplayAlert("Error", "Seleccione una categoria", "Ok");
            }*/

        }
        //Devuelve al usuario al menu de busqueda
        #endregion
        #region favoritos

        #endregion
        #region chat

        #endregion
        #region addProduct

        #endregion
    }
}