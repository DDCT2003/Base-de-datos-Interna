using BaseDatosInterna.Models;
using BaseDatosInterna.ViewModels;

namespace BaseDatosInterna.Views;

public partial class DetalleProductoPage : ContentPage
{
   
    public DetalleProductoPage(Productos producto)
	{
		InitializeComponent();
        
        BindingContext = new DetalleProductoViewModel(producto);
	}
    
}