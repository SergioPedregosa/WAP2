using System.ComponentModel;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class DetailsAnuncioViewModel : Anuncio, INotifyPropertyChanged
    {
        #region Attributes
        private DialogService dialogService;
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
        public DetailsAnuncioViewModel(Anuncio anuncio)
        {
            dialogService = new DialogService();
            navigationService = new NavigationService();

            ProductId = anuncio.ProductId;
            Name = anuncio.Name;
            Description = anuncio.Description;
            Price = anuncio.Price;
            Status = anuncio.Status;
            Created = anuncio.Created;
            Image = anuncio.Image;
            TempBarValue = anuncio.TempBarValue;
            User_RID = anuncio.User_RID;
            FrameColor = anuncio.FrameColor;
            AnuncioId = anuncio.AnuncioId;
            Estado = anuncio.Estado;

            currentProgressValue = anuncio.TempBarValue;
            totalProgressValue = (int)anuncio.Price;
            progressValue = (double)currentProgressValue / totalProgressValue;

            IsEnabled = true;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
