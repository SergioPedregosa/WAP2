using System;
using System.Collections.Generic;
using System.Text;
using WAP2.ViewModels;

namespace WAP2.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public BuscadorViewModel Buscador { get; set; }
        public AddressViewModel Address { get; set; }
        public AddProductoViewModel AddProducto { get; set; }
        public PedidosViewModel Pedidos { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
            Buscador = new BuscadorViewModel();
            Address = new AddressViewModel();
            AddProducto = new AddProductoViewModel();
            Pedidos = new PedidosViewModel();
        }
    }
}
