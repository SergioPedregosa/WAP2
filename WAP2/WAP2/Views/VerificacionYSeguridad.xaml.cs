using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using WAP2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerificacionYSeguridad : ContentPage
    {
        public VerificacionYSeguridad()
        {
            InitializeComponent();
            //GetClaims();
        }

        private void navToCambiarContraseña(object sender, EventArgs e)
        {

        }

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
                    mostrarCorreo.Text = $"{data.Claims.FirstOrDefault(x => x.Type.Equals("emails")).Value}";
                }
            }
        }
    }
}