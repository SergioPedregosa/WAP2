using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WAP2.Models;
using WAP2.ViewModels;
using Xamarin.Forms;

namespace WAP2.Services
{
    //Clase temporal mientras Azure no esta disponible
    // IMPORTANTE BORRAR CUANDO VUELVA A ESTAR DISPONIBLE AZURE ---------------------------------------------------------------------------------
    public class ProductService
    {
        List<ObservableCollection<ProductItemViewModel>> productsObservable = new List<ObservableCollection<ProductItemViewModel>>();
        List<Producto> products = new List<Producto>();
        List<ParticipationItemViewModel> participations = new List<ParticipationItemViewModel>();
        List<AnunciosViewModel> anuncios = new List<AnunciosViewModel>();
        static ProductItemViewModel producto1 = new ProductItemViewModel
        {
            ProductId = 1,
            Name = "Test",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id leo ullamcorper, scelerisque leo eget, pretium diam. Sed gravida fermentum risus, nec varius eros sodales vel. Nam ornare erat leo, eu semper nibh molestie at. Quisque dignissim dapibus neque, ut elementum leo interdum ac. Vestibulum tincidunt massa at est sagittis gravida. Aliquam semper congue metus vitae sollicitudin. Donec volutpat nulla nec ligula posuere, pharetra efficitur nisi vulputate.",
            Price = 50,
            Created = DateTime.Now,
            Category = "Motor y Accesorios",
            Subcategory = "GPS y Electrónica",
            Status = "Nuevo",
            Image = "a01.png",
            TempBarValue = 10,
            User_RID = "01"
        };
        static ProductItemViewModel producto2 = new ProductItemViewModel
        {
            ProductId = 2,
            Name = "Test",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id leo ullamcorper, scelerisque leo eget, pretium diam. Sed gravida fermentum risus, nec varius eros sodales vel. Nam ornare erat leo, eu semper nibh molestie at. Quisque dignissim dapibus neque, ut elementum leo interdum ac. Vestibulum tincidunt massa at est sagittis gravida. Aliquam semper congue metus vitae sollicitudin. Donec volutpat nulla nec ligula posuere, pharetra efficitur nisi vulputate.",
            Price = 50,
            Created = DateTime.Now,
            Category = "Motor y Accesorios",
            Subcategory = "GPS y Electrónica",
            Status = "Nuevo",
            Image = "a02.png",
            TempBarValue = 10,
            User_RID = "02"
        };
        static ProductItemViewModel producto3 = new ProductItemViewModel
        {
            ProductId = 3,
            Name = "Test",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id leo ullamcorper, scelerisque leo eget, pretium diam. Sed gravida fermentum risus, nec varius eros sodales vel. Nam ornare erat leo, eu semper nibh molestie at. Quisque dignissim dapibus neque, ut elementum leo interdum ac. Vestibulum tincidunt massa at est sagittis gravida. Aliquam semper congue metus vitae sollicitudin. Donec volutpat nulla nec ligula posuere, pharetra efficitur nisi vulputate.",
            Price = 50,
            Created = DateTime.Now,
            Category = "Motor y Accesorios",
            Subcategory = "GPS y Electrónica",
            Status = "Nuevo",
            Image = "a03.png",
            TempBarValue = 10,
            User_RID = "01"
        };
        static ProductItemViewModel producto4 = new ProductItemViewModel
        {
            ProductId = 4,
            Name = "Test",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id leo ullamcorper, scelerisque leo eget, pretium diam. Sed gravida fermentum risus, nec varius eros sodales vel. Nam ornare erat leo, eu semper nibh molestie at. Quisque dignissim dapibus neque, ut elementum leo interdum ac. Vestibulum tincidunt massa at est sagittis gravida. Aliquam semper congue metus vitae sollicitudin. Donec volutpat nulla nec ligula posuere, pharetra efficitur nisi vulputate.",
            Price = 50,
            Created = DateTime.Now,
            Category = "Motor y Accesorios",
            Subcategory = "GPS y Electrónica",
            Status = "Nuevo",
            Image = "a04.png",
            TempBarValue = 10,
            User_RID = "01"
        };
        static ProductItemViewModel producto5 = new ProductItemViewModel
        {
            ProductId = 5,
            Name = "Test",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id leo ullamcorper, scelerisque leo eget, pretium diam. Sed gravida fermentum risus, nec varius eros sodales vel. Nam ornare erat leo, eu semper nibh molestie at. Quisque dignissim dapibus neque, ut elementum leo interdum ac. Vestibulum tincidunt massa at est sagittis gravida. Aliquam semper congue metus vitae sollicitudin. Donec volutpat nulla nec ligula posuere, pharetra efficitur nisi vulputate.",
            Price = 50,
            Created = DateTime.Now,
            Category = "Motor y Accesorios",
            Subcategory = "GPS y Electrónica",
            Status = "Nuevo",
            Image = "a05.png",
            TempBarValue = 10,
            User_RID = "01"
        };
        //SIMULACIÓN PARTICIPACIONES
        ParticipationItemViewModel participacion1 = new ParticipationItemViewModel
        {
            ParticipacionId = 01,
            NumeroParticipaciones = 1,
            Estado = "En curso...",
            FrameColor = Color.FromHex("#d3e4e5"),
            ProductId = producto1.ProductId,
            Name = producto1.Name,
            Description = producto1.Description,
            Price = producto1.Price,
            Created = producto1.Created,
            Category = producto1.Category,
            Subcategory = producto1.Subcategory,
            Status = producto1.Status,
            Image = producto1.Image,
            TempBarValue = producto1.TempBarValue,
            User_RID = producto1.User_RID
        };
        ParticipationItemViewModel participacion2 = new ParticipationItemViewModel
        {
            ParticipacionId = 02,
            NumeroParticipaciones = 3,
            Estado = "En curso...",
            FrameColor = Color.FromHex("#d3e4e5"),
            ProductId = producto2.ProductId,
            Name = producto2.Name,
            Description = producto2.Description,
            Price = producto2.Price,
            Created = producto2.Created,
            Category = producto2.Category,
            Subcategory = producto2.Subcategory,
            Status = producto2.Status,
            Image = producto2.Image,
            TempBarValue = producto2.TempBarValue,
            User_RID = producto2.User_RID
        };
        ParticipationItemViewModel participacion3 = new ParticipationItemViewModel
        {
            ParticipacionId = 03,
            NumeroParticipaciones = 1,
            Estado = "Perdida",
            FrameColor = Color.FromHex("#efd6d6"),
            ProductId = producto3.ProductId,
            Name = producto3.Name,
            Description = producto3.Description,
            Price = producto3.Price,
            Created = producto3.Created,
            Category = producto3.Category,
            Subcategory = producto3.Subcategory,
            Status = producto3.Status,
            Image = producto3.Image,
            TempBarValue = producto3.TempBarValue,
            User_RID = producto3.User_RID
        };
        ParticipationItemViewModel participacion4 = new ParticipationItemViewModel
        {
            ParticipacionId = 04,
            NumeroParticipaciones = 5,
            Estado = "En rifa",
            FrameColor = Color.FromHex("#f6f2d3"),
            ProductId = producto4.ProductId,
            Name = producto4.Name,
            Description = producto4.Description,
            Price = producto4.Price,
            Created = producto4.Created,
            Category = producto4.Category,
            Subcategory = producto4.Subcategory,
            Status = producto4.Status,
            Image = producto4.Image,
            TempBarValue = producto4.TempBarValue,
            User_RID = producto4.User_RID
        };
        ParticipationItemViewModel participacion5 = new ParticipationItemViewModel
        {
            ParticipacionId = 05,
            NumeroParticipaciones = 1,
            Estado = "Ganada",
            FrameColor = Color.FromHex("#d5f1d8"),
            ProductId = producto5.ProductId,
            Name = producto5.Name,
            Description = producto5.Description,
            Price = producto5.Price,
            Created = producto5.Created,
            Category = producto5.Category,
            Subcategory = producto5.Subcategory,
            Status = producto5.Status,
            Image = producto5.Image,
            TempBarValue = producto5.TempBarValue,
            User_RID = producto5.User_RID
        };
        //SIMULACION ANUNCIOS
        AnunciosViewModel anuncio1 = new AnunciosViewModel
        {
            AnuncioId = 01,
            Estado = "Sin empezar",
            FrameColor = Color.FromHex("#e8d8de"),
            ProductId = producto1.ProductId,
            Name = producto1.Name,
            Description = producto1.Description,
            Price = producto1.Price,
            Created = producto1.Created,
            Category = producto1.Category,
            Subcategory = producto1.Subcategory,
            Status = producto1.Status,
            Image = producto1.Image,
            TempBarValue = producto1.TempBarValue,
            User_RID = producto1.User_RID
        };
        AnunciosViewModel anuncio2 = new AnunciosViewModel
        {
            AnuncioId = 02,
            Estado = "En curso",
            FrameColor = Color.FromHex("#d3e4e5"),
            ProductId = producto2.ProductId,
            Name = producto2.Name,
            Description = producto2.Description,
            Price = producto2.Price,
            Created = producto2.Created,
            Category = producto2.Category,
            Subcategory = producto2.Subcategory,
            Status = producto2.Status,
            Image = producto2.Image,
            TempBarValue = producto2.TempBarValue,
            User_RID = producto2.User_RID
        };
        AnunciosViewModel anuncio3 = new AnunciosViewModel
        {
            AnuncioId = 03,
            Estado = "Vendido",
            FrameColor = Color.FromHex("#d5f1d8"),
            ProductId = producto3.ProductId,
            Name = producto3.Name,
            Description = producto3.Description,
            Price = producto3.Price,
            Created = producto3.Created,
            Category = producto3.Category,
            Subcategory = producto3.Subcategory,
            Status = producto3.Status,
            Image = producto3.Image,
            TempBarValue = producto3.TempBarValue,
            User_RID = producto3.User_RID
        };
        AnunciosViewModel anuncio4 = new AnunciosViewModel
        {
            AnuncioId = 04,
            Estado = "En rifa",
            FrameColor = Color.FromHex("#f6f2d3"),
            ProductId = producto4.ProductId,
            Name = producto4.Name,
            Description = producto4.Description,
            Price = producto4.Price,
            Created = producto4.Created,
            Category = producto4.Category,
            Subcategory = producto4.Subcategory,
            Status = producto4.Status,
            Image = producto4.Image,
            TempBarValue = producto4.TempBarValue,
            User_RID = producto4.User_RID
        };
        AnunciosViewModel anuncio5 = new AnunciosViewModel
        {
            AnuncioId = 05,
            Estado = "Sin vender",
            FrameColor = Color.FromHex("#efd6d6"),
            ProductId = producto5.ProductId,
            Name = producto5.Name,
            Description = producto5.Description,
            Price = producto5.Price,
            Created = producto5.Created,
            Category = producto5.Category,
            Subcategory = producto5.Subcategory,
            Status = producto5.Status,
            Image = producto5.Image,
            TempBarValue = producto5.TempBarValue,
            User_RID = producto5.User_RID
        };
        public List<Producto> MountList()
        {
            products.Add(producto1);
            products.Add(producto2);
            products.Add(producto3);
            products.Add(producto4);
            products.Add(producto5);
            return products;
        }
        public List<ParticipationItemViewModel> ParticipationList()
        {
            participations.Add(participacion1);
            participations.Add(participacion2);
            participations.Add(participacion3);
            participations.Add(participacion4);
            participations.Add(participacion5);
            return participations;
        }
        public List<AnunciosViewModel> AnuncioList()
        {
            anuncios.Add(anuncio1);
            anuncios.Add(anuncio2);
            anuncios.Add(anuncio3);
            anuncios.Add(anuncio4);
            anuncios.Add(anuncio5);
            return anuncios;
        }
    }
}
