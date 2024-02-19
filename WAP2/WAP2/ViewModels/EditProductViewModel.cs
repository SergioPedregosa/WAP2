using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Services;

namespace WAP2.ViewModels
{
    public class EditProductViewModel : Producto, INotifyPropertyChanged
    {
        #region Attributes
        private DialogService dialogService;
        private ApiService apiService;
        private NavigationService navigationService;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
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
        public EditProductViewModel(Producto producto)
        {
            dialogService = new DialogService();
            apiService = new ApiService();
            navigationService = new NavigationService();

            ProductId = producto.ProductId;
            Name = producto.Name;
            Description = producto.Description;
            Price = producto.Price;
            Created = producto.Created;

            IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand SaveProductoCommand { get { return new RelayCommand(SaveProducto); } }

        private async void SaveProducto()
        {
            if (string.IsNullOrEmpty(Name))
            {
                await dialogService.ShowMessage("Error", "En nombre esta vacío o no es valido");
                return;
            }
            if (string.IsNullOrEmpty(Description))
            {
                await dialogService.ShowMessage("Error", "La descripción esta vacía o no es valida");
                return;
            }
            if (Price <= 0)
            {
                await dialogService.ShowMessage("Error", "El precio tiene que ser superior a 0");
                return;
            }

            IsRunning = true;
            IsEnabled = false;
            var response = await apiService.Put("https://wapback.azurewebsites.net", "/api", "/Products", this);
            IsRunning = false;
            IsEnabled = true;

            if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error", response.Message);
                return;
            }
            await navigationService.Back();
        }
        public ICommand DeleteProductoCommand { get { return new RelayCommand(DeleteProducto); } }

        private async void DeleteProducto()
        {
            var answer = await dialogService.ShowConfirm("Confirmar", "¿Estas seguro que quieres borrar este producto?");
            if (!answer)
            {
                return;
            }
            IsRunning = true;
            IsEnabled = false;
            var response = await apiService.Delete("https://wapback.azurewebsites.net", "/api", "/Products", this);
            IsRunning = false;
            IsEnabled = true;

            if (!response.IsSuccess)
            {
                await dialogService.ShowMessage("Error", response.Message);
                return;
            }
            await navigationService.Back();
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
