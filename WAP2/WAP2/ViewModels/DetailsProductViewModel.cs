using System.ComponentModel;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class DetailsProductViewModel : Producto, INotifyPropertyChanged
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
        public DetailsProductViewModel(Producto producto)
        {
            dialogService = new DialogService();
            apiService = new ApiService();
            navigationService = new NavigationService();

            ProductId = producto.ProductId;
            Name = producto.Name;
            Description = producto.Description;
            Price = producto.Price;
            Status = producto.Status;
            Created = producto.Created;
            Image = producto.Image;
            TempBarValue = producto.TempBarValue;
            User_RID = producto.User_RID;

            currentProgressValue = TempBarValue;
            totalProgressValue = (int)producto.Price;
            progressValue = (double)currentProgressValue / totalProgressValue;

            IsEnabled = true;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
