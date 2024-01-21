using BaseDatosInterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BaseDatosInterna.ViewModels
{
    public class NuevoProductoViewModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public Productos produ  { get; set; }


        public NuevoProductoViewModel(Productos producto) { 
            produ= producto;
        }

        public ICommand GuardarProducto =>
            new Command( async () =>
            {
                if(produ !=null) {
                    produ.Nombre = Nombre;
                    produ.Descripcion = Descripcion;
                    produ.Cantidad=Cantidad;
                    App.ProductoRepository.Update(produ);
                    await App.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    Productos producto = new Productos
                    {
                        Nombre = Nombre,
                        Descripcion = Descripcion,
                        Cantidad = Cantidad
                    };
                    
                    App.ProductoRepository.Add(producto);
                    await App.Current.MainPage.Navigation.PopAsync();
                }
                
               

            }
            );
    }
}
