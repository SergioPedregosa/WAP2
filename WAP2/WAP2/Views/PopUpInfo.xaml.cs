using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms.Xaml;

namespace WAP2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUpInfo : Popup
	{
		public string Status;
		public PopUpInfo (string status)
		{
			Status = status;
			InitializeComponent ();
			textEstado.Text = status;
			textMessage.Text = GenerateMessage();
			
		}
		public string GenerateMessage()
		{
			string result = string.Empty;
			switch (Status)
			{
				case "En curso...":
					result = "El sorteo que tendrá lugar cuando llegue al monto del valor del producto o si el vendedor decide que el monto actual le es suficiente." +
						"\nSi pasado 1 mes bi se ha realizado el sorteo se ciera automáticamente y se devuelve el dinero de cada participante como en la compra.";
					break;
				case "Sin empezar":
					result = "Con la primera venta se empezará a contar 1 mes, y su no se ha realizado el sorteo se cierra automáticamente y se devuelve el dinero de cada participante como en la compra.";
					break;
				case "En rifa":
					result = "El sorteo que tendrá lugar entre los próximos 3 días (se necesita ir a un notario...)";
					break;
				case "Sin vender":
					result = "Se ha cerrado esta venta porque ha pasado más de un mes desde su primera venta." +
						"\nSi quieres puedes volver a subirlo para probar suerte otra vez.";
					break;
			}
			return result;
		}
	}
}