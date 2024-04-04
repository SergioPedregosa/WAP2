using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class ParticipationItemViewModel : Participacion
    {
        private NavigationService navigationService;
        public ParticipationItemViewModel()
        {
            navigationService = new NavigationService();
        }
        public ICommand EditParticipationCommand { get { return new RelayCommand(EditParticipation); } }
        public ICommand DetailsParticipationCommand { get { return new RelayCommand(DetailsParticipation); } }

        private void EditParticipation()
        {
            //await navigationService.EditParticipation(this);
        }
        private async void DetailsParticipation()
        {
            await navigationService.DetailsParticipation(this);
        }
    }
}
