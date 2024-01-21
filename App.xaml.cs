using BaseDatosInterna.Service;
using BaseDatosInterna.Views;

namespace BaseDatosInterna
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepository { get; set; }
        public App()
        {
            InitializeComponent();
            ProductoRepository = new ProductoRepository();
            MainPage = new NavigationPage(new ProductosPage());
        }
    }
}