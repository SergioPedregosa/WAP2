using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class AnunciosViewModel : Anuncio
    {
        private NavigationService navigationService;
        public AnunciosViewModel() 
        {
            navigationService = new NavigationService();
        }
        public ICommand EditAnuncioCommand { get { return new RelayCommand(EditAnuncio); } }
        public ICommand DetailsAnuncioCommand { get { return new RelayCommand(DetailsAnuncio); } }

        private void EditAnuncio()
        {
            //await navigationService.EditParticipation(this);
        }
        private async void DetailsAnuncio()
        {
            await navigationService.DetailsAnuncio(this);
        }
    }
}
