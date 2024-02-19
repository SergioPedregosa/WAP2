using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class DetailsParticipationViewModel : Participacion, INotifyPropertyChanged
    {
        #region Attributes
        private DialogService dialogService;
        private ApiService apiService;
        private NavigationService navigationService;
        private int currentProgressValue;
        private int totalProgressValue;
        private double progressValue;
        private bool isRunning;
        private bool isEnabled;
        #endregion
        #region Properties
        public int CurrentProgressValue
        {
            set
            {
                if (currentProgressValue != value)
                {
                    currentProgressValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentProgressValue"));
                }
            }
            get { return currentProgressValue; }
        }
        public int TotalProgressValue
        {
            set
            {
                if (totalProgressValue != value)
                {
                    totalProgressValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalProgressValue"));
                }
            }
            get { return totalProgressValue; }
        }
        public double ProgressValue
        {
            set
            {
                if (progressValue != value)
                {
                    progressValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProgressValue"));
                }
            }
            get { return progressValue; }
        }
        public bool IsRunning
        {
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                }
            }
            get { return isRunning; }
        }
        public bool IsEnabled
        {
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnabled"));
                }
            }
            get { return isEnabled; }
        }
        #endregion
        #region Constructors
        public DetailsParticipationViewModel(Participacion participacion)
        {
            dialogService = new DialogService();
            apiService = new ApiService();
            navigationService = new NavigationService();

            ProductId = participacion.ProductId;
            Name = participacion.Name;
            Description = participacion.Description;
            Price = participacion.Price;
            Status = participacion.Status;
            Created = participacion.Created;
            Image = participacion.Image;
            TempBarValue = participacion.TempBarValue;
            User_RID = participacion.User_RID;
            FrameColor = participacion.FrameColor;
            ParticipacionId = participacion.ParticipacionId;
            NumeroParticipaciones = participacion.NumeroParticipaciones;
            Estado = participacion.Estado;

            currentProgressValue = TempBarValue;
            totalProgressValue = (int)participacion.Price;
            progressValue = (double)currentProgressValue / totalProgressValue;

            IsEnabled = true;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
