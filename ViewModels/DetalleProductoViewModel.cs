using BaseDatosInterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Input;
using BaseDatosInterna.Views;
using System.ComponentModel;

namespace BaseDatosInterna.ViewModels
{
    public class DetalleProductoViewModel 
    {
        public Productos produ { get; set; }
     
        public DetalleProductoViewModel(Productos producto)
        {
            
            produ = producto;
        }

        public ICommand EditarProducto =>
            new Command(async () =>
            {

                await App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage(produ)
                
                ) ;
            }
            );
        public ICommand BorrarProducto =>
            new Command(async () =>
            {
                Productos productos = App.ProductoRepository.Get(produ.IdProducto);
                
                App.ProductoRepository.Delete(produ.IdProducto);

                await App.Current.MainPage.Navigation.PopAsync();
            }
            );
       
    }
}
