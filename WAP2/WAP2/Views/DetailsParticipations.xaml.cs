using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsParticipations : ContentPage
	{
		public DetailsParticipations ()
		{
			InitializeComponent ();
		}

        private void ShowPopUp(object sender, EventArgs e)
        {
			Navigation.ShowPopup(new PopUpInfo(EstadoPart.Text));
        }
    }
}