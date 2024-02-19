﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class PedidosViewModel : INotifyPropertyChanged
	{
        #region Attributes
        private ApiService apiService;
        private NavigationService navigationService;
        private DialogService dialogService;
        private bool isRefreshing;
        #endregion
        #region Properties
        public ObservableCollection<ParticipationItemViewModel> Participations { get; set;}
        public DetailsParticipationViewModel DetailsParticipations { get; set;}
        public bool IsRefreshing
        {
            set
            {
                if (isRefreshing != value)
                {
                    isRefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
                }
            }
            get
            {
                return isRefreshing;
            }
        }

        #endregion
        #region Constructor
        public PedidosViewModel()
        {
            //Singleton
            instance = this;

            //Services
            apiService = new ApiService();
            navigationService = new NavigationService();
            dialogService = new DialogService();

            //ViewModels
            Participations = new ObservableCollection<ParticipationItemViewModel>();
        }
        #endregion
        #region Methods
        #endregion
        #region Commands
        #endregion
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        #region Singleton
        private static PedidosViewModel instance;
        public static PedidosViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new PedidosViewModel();
            }
            return instance;
        }
        #endregion
    }
}