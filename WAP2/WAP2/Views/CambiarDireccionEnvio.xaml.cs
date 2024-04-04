using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CambiarDireccionEnvio : ContentPage
    {
        private readonly Geocoder geocoder = new Geocoder();
        Pin MyAddress;
        Pin NewAddress;
        public CambiarDireccionEnvio()
        {
            InitializeComponent();
            MyAddress = new Pin()
            {
                Type = PinType.Place,
                Label = "Dirección actual",
                Address = "Carrer de la Gorgonçana, 3, 08292 Esparreguera, Barcelona, Spain",
                Position = new Position(41.5385, 1.8733),
                Tag = "id_address"
            };

            Map.Pins.Add(MyAddress);
            Map.MoveToRegion(MapSpan.FromCenterAndRadius(MyAddress.Position, Distance.FromMeters(500)));

        }

        private void NavToCondiciones(object sender, EventArgs e)
        {

        }

        private void NavToPoliticaPrivacidad(object sender, EventArgs e)
        {

        }

        private async void setNewAddress(object sender, MapClickedEventArgs e)
        {
            try
            {
                Map.Pins.Remove(NewAddress);
                var address = await geocoder.GetAddressesForPositionAsync(e.Point);
                NewAddress = new Pin()
                {
                    Type = PinType.Place,
                    Icon = BitmapDescriptorFactory.DefaultMarker(Color.Blue),
                    Label = "Nueva dirección",
                    Address = address.FirstOrDefault()?.ToString(),
                    Position = new Position(e.Point.Latitude, e.Point.Longitude),
                    Tag = "id_newAddress"
                };
                Map.Pins.Add(NewAddress);
                detailsAddress.Text = address.FirstOrDefault()?.ToString();
                entryLat.Text = e.Point.Latitude.ToString();
                entryLon.Text = e.Point.Longitude.ToString();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }

        }
    }
}