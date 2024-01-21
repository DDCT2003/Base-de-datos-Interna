using BaseDatosInterna.Models;
using BaseDatosInterna.ViewModels;

namespace BaseDatosInterna.Views;

public partial class NuevoProductoPage : ContentPage
{
    private Productos _producto;
    public NuevoProductoPage(Productos p)
	{
		InitializeComponent();
        
        BindingContext = new NuevoProductoViewModel(p);
	}
}