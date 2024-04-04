using System.Threading.Tasks;

namespace WAP2.Services
{
    public class DialogService
    {
        //Muestra un mensaje simple
        public async Task ShowMessage(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }
        //Muestra un mensaje con confirmación (Si/No)
        public async Task<bool> ShowConfirm(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Si", "No");
        }
        //Deja seleccionar si se quiere hacer una foto o seleccionar una de la galeria
        public async Task<bool> SelectOptionPhoto(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Hacer una foto", "Seleccionar de la galeria");
        }
    }
}
