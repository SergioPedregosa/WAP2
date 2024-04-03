using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using WAP2.Models;
using WAP2.Services;
using WAP2.ViewModels;
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

            //GetClaims();
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
        //Llama los Claims del usuario de Azure
        private void GetClaims()
        {
            var token = Transporter.authenticationResult.IdToken;
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var data = handler.ReadJwtToken(token);
                var claims = data.Claims.ToList();
                if (data != null)
                {
                    //UserRID.Text = $"{data.Claims.FirstOrDefault(x => x.Type.Equals("oid")).Value}";

                }
            }
        }
        private void CambiarFoto1(object sender, EventArgs e)
        {
            
        }
    }
}