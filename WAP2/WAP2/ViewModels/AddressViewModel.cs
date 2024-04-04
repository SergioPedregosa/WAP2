using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class AddressViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private DialogService dialogService;
        private NavigationService navigationService;
        private string name;
        private string addressInfo;
        private string floor;
        private float lat;
        private float lon;
        private string userRID;
        private bool isRunning;
        private bool isEnabled;
        private bool isRefreshing;
        private int AddressCount = 0;
        #endregion
        #region Properties
        public ObservableCollection<AddressViewModel> addresses { get; set; }

        public string Name
        {
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get { return name; }
        }
        public string AddressInfo
        {
            set
            {
                if (addressInfo != value)
                {
                    addressInfo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AddressInfo"));
                }
            }
            get { return addressInfo; }
        }
        public string Floor
        {
            set
            {
                if (floor != value)
                {
                    floor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Floor"));
                }
            }
            get { return floor; }
        }
        public float Lat
        {
            set
            {
                if (lat != value)
                {
                    lat = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lat"));
                }
            }
            get { return lat; }
        }
        public float Lon
        {
            set
            {
                if (lon != value)
                {
                    lon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lon"));
                }
            }
            get { return lon; }
        }
        public string UserRID
        {
            set
            {
                if (userRID != value)
                {
                    userRID = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserRID"));
                }
            }
            get { return userRID; }
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
        }
        #endregion
        #region Constructors
        public AddressViewModel()
        {
            dialogService = new DialogService();
            navigationService = new NavigationService();
            IsEnabled = true;

            addresses = new ObservableCollection<AddressViewModel>();
        }
        #endregion
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Methods
        //Cargar direcciones de la base de datos
        private async void LoadAddresses()
        {
            //TODO: Crear tablas de direcciones en Firebase y comando de cargar todas las direcciones del usuario

            //FilterAddresses((List<Address>)response.Result, UserRID);
        }
        //Filtrar direcciones del usuario
        private void FilterAddresses(List<Address> listAddresses, string UserID)
        {
            addresses.Clear();
            AddressCount = 0;
            foreach (var address in listAddresses.Where(w => w.UserRID == UserID))
            {
                addresses.Add(new AddressViewModel
                {
                    Name = address.Name,
                    AddressInfo = address.AddressInfo,
                    Floor = address.Floor,
                    Lat = address.Lat,
                    Lon = address.Lon,
                    UserRID = UserID
                });
                AddressCount++;
            }
            RefreshAddresses();
        }
        //Cargar direcciones
        public void Load()
        {
            LoadAddresses();
        }
        #endregion
        #region Commands
        public ICommand RefreshAddressesCommand { get { return new RelayCommand(RefreshAddresses); } }
        private void RefreshAddresses()
        {
            IsRefreshing = true;
            LoadAddresses();
            IsRefreshing = false;
        }
        public ICommand AddAddressCommand { get { return new RelayCommand(AddAddress); } }
        private async void AddAddress()
        {
            await dialogService.ShowMessage("Test", "Ok");
            var address = new Address()
            {
                Name = Name,
                AddressInfo = AddressInfo,
                Floor = Floor,
                Lat = Lat,
                Lon = Lon,
                UserRID = UserRID
            };

            IsRunning = true;
            IsEnabled = false;

            //TODO Comando subir direccion a firebase

            isRunning = false;
            isEnabled = true;

            /**if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error", response.Message);
                return;
            }**/
            await navigationService.Back();
        }
        #endregion
    }
}
