using CommunityToolkit.Mvvm.Input;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using WAP2.Models;
using WAP2.Resources.Repositories;
using WAP2.Services;
using Xamarin.Forms;

namespace WAP2.ViewModels
{
    public class AddProductoViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private DialogService dialogService;
        private NavigationService navigationService;
        private ProductRepository productRepository = new ProductRepository();
        private string name;
        private string description;
        private decimal price;
        private DateTime created;
        private string category;
        private string subcategory;
        private string status;
        private string user_RID;
        private bool isRunning;
        private bool isEnabled;
        private ImageSource imageSource;
        private MediaFile file;
        #endregion
        #region Properties
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
        public string Description
        {
            set
            {
                if (description != value)
                {
                    description = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                }
            }
            get { return description; }
        }
        public decimal Price
        {
            set
            {
                if (price != value)
                {
                    price = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
            }
            get { return price; }
        }
        public DateTime Created
        {
            set
            {
                if (created != value)
                {
                    created = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Created"));
                }
            }
            get { return created; }
        }
        public string Category
        {
            set
            {
                if (category != value)
                {
                    category = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Category"));
                }
            }
            get { return category; }
        }
        public string Subcategory
        {
            set
            {
                if (subcategory != value)
                {
                    subcategory = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subcategory"));
                }
            }
            get { return subcategory; }
        }
        public string Status
        {
            set
            {
                if (status != value)
                {
                    status = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Status"));
                }
            }
            get { return status; }
        }
        public string User_RID
        {
            set
            {
                if (user_RID != value)
                {
                    user_RID = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("User_RID"));
                }
            }
            get { return user_RID; }
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
        public ImageSource ImageSource
        {
            set
            {
                if (imageSource != value)
                {
                    imageSource = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageSource"));
                }
            }
        }
        #endregion
        #region Constructors
        public AddProductoViewModel()
        {
            dialogService = new DialogService();
            navigationService = new NavigationService();
            IsEnabled = true;
        }
        #endregion
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        #region Commands
        //Comando para tomar fotos
        public ICommand TakePictureCommand { get { return new RelayCommand(TakePicture); } }
        private async void TakePicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await dialogService.ShowMessage("No camera", ":( No camera available.");
            }

            bool options = await dialogService.SelectOptionPhoto("Subir imagen", "¿Desde donde quiere subir la imagen?");

            if (options)
            {
                file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "test.jpg",
                    PhotoSize = PhotoSize.Full
                });
            }
            else
            {
                file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                {

                });
            }
            IsRunning = true;

            if (file != null)
            {
                ImageSource = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    return stream;
                });
            }

            IsRunning = false;
        }
        //Añadir producto
        public ICommand AddProductCommand { get { return new RelayCommand(NewProducto); } }
        private async void NewProducto()
        {
            if (string.IsNullOrEmpty(Name))
            {
                await dialogService.ShowMessage("Error", "Introduce el nombre del producto");
                return;
            }
            if (Price <= 0)
            {
                await dialogService.ShowMessage("Error", "Introduce un precio valido, superior a 0");
                return;
            }

            if (string.IsNullOrEmpty(Description))
            {
                await dialogService.ShowMessage("Error", "Introduce una descripción del producto");
                return;
            }

            string image = await productRepository.UploadPhoto(file.GetStream(), Path.GetFileName(file.Path));

            //Eliminar TempBarValue al implementar correctamente las participaciones --------------------------------------------------

            var product = new Producto()
            {
                Name = Name,
                Description = Description,
                Price = Price,
                Created = DateTime.Now,
                Category = Category,
                Subcategory = Subcategory,
                Status = Status,
                Image = image,
                //TempBarValue = 0,
                
                //User_RID = User_RID

            };
            

            IsRunning = true;
            IsEnabled = false;

            //Comando subir producto a Firebase
            var response = await productRepository.Save(product);

            isRunning = false;
            isEnabled = true;

            if (!response)
            {
                await dialogService.ShowMessage("Error", "Fallo al subir producto");
                return;
            }

            await navigationService.BuyProduct();
        }
        #endregion
    }
}
