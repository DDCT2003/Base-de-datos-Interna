using BaseDatosInterna.Models;
using BaseDatosInterna.ViewModels;

namespace BaseDatosInterna.Views;

public partial class ProductosPage : ContentPage
{
    private readonly ProductosViewModel _viewModel;
    public ProductosPage()
	{
		InitializeComponent();
        _viewModel = new ProductosViewModel();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing() 
    {
        base.OnAppearing();
        _viewModel.CargarProductos();
    }
    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        
        Productos producto = e.SelectedItem as Productos;
        await Navigation.PushAsync(new DetalleProductoPage(producto));
    }
}