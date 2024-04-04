using System;
using WAP2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProducto : ContentPage
    {
        PickerService pickerService;
        public AddProducto()
        {
            InitializeComponent();
            pickerService = new PickerService();

            //Carga los pickers
            PickerCategoria.ItemsSource = pickerService.categoryPickerList();
            PickerEstado.ItemsSource = pickerService.statusPickerList();

        }
        // Carga una lista de subcategorias en el picker de subcategorias en función de la categoria seleccionada
        private void PickerCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PickerSubcategoria.ItemsSource != null)
            {
                PickerSubcategoria.ItemsSource = null;
                PickerSubcategoria.Items.Clear();
            }
            PickerSubcategoria.ItemsSource = pickerService.subcategoryPickerList(PickerCategoria.SelectedItem.ToString());
        }
        
    }
}