using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAP2.Services;
using WAP2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BuscadorProducto : ContentPage
	{
        PickerService pickerService;
        BuscadorViewModel buscadorViewModel;
        //TEMPORAL
        ProductService productService;
        public BuscadorProducto()
        {
            InitializeComponent();
            buscadorViewModel = BuscadorViewModel.GetInstance();
            productService = new ProductService();

            pickerService = new PickerService();
            ProductTemplate.ItemsSource = productService.MountList();

            //PickerCategoria.ItemsSource = pickerService.categoryPickerList();


        }
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
    }
}