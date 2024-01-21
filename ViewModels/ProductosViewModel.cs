using BaseDatosInterna.Models;
using BaseDatosInterna.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaseDatosInterna.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ProductosViewModel 
    {
        public ObservableCollection<Productos> ListaProductos { get; set; }

        public ProductosViewModel() { 
        ListaProductos = new ObservableCollection<Productos>(App.ProductoRepository.GetAll());
        }

        public ICommand CrearProducto =>
            new Command( async () =>
            {
               await App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage(null));
                
            });

        public void CargarProductos()
        {
            ListaProductos = new ObservableCollection<Productos>(App.ProductoRepository.GetAll());
        }

       
    }
}
