using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WAP2.Services
{
    public class DialogService
    {
        public async Task ShowMessage(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }
        public async Task<bool> ShowConfirm(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Si", "No");
        }
        public async Task<bool> SelectOptionPhoto(string title, string message)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, "Hacer una foto", "Seleccionar de la galeria");
        }
    }
}
