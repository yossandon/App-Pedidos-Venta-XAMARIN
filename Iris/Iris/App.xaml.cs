using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.Views;
using Pedidos.ViewModels;
using Pedidos.Helpers;
using Pedidos.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Pedidos
{
    public partial class App : Application
	{
        public static NavigationPage Navigator
        {
            get;
            internal set;
        }
        public App()
        {
            InitializeComponent();
            Variables_Globales.Id_Empresa = 70;
            Variables_Globales.Id_Comanda = 0;
            Variables_Globales.Id_Mesa = 0;
            BaseDatos.Obtener_Datos_Empleado("APP");
            Variables_Globales.Lista_Catgeorias = BaseDatos.Trae_Categoria_APP("%");
            BaseDatos.Obtener_Datos_Anexo_Empresa(Variables_Globales.Id_Empresa);
            BaseDatos.Obtener_todas_las_Categorias_APP();
            Variables_Globales.Lista_Articulos = BaseDatos.Llenar_Lista_con_Articulos_x_Categoria(Variables_Globales.Categroia_1);
            Variables_Globales.Lista_Articulos_Recomendados = BaseDatos.Llenar_Lista_con_Articulos_Recomendados(Variables_Globales.Id_Empresa);
            Variables_Globales.Color = "MediumSeaGreen";
            Variables_Globales.Estado_Mesa = 510;
            //this.MainPage = new NavigationPage(new LoginPage());
            if (string.IsNullOrEmpty(Settings.Token))
            {
                this.MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = Settings.Token;
                mainViewModel.TokenType = Settings.TokenType;
                Variables_Globales.Usuario = string.Empty;
                BaseDatos.Trae_Datos_Cliente(Settings.Token);
                BaseDatos.Trae_Primera_Direccion_Cliente(Variables_Globales.Id_Cliente);
                if (Variables_Globales.Estado_Cliente != 1)  // Solo usuario Vigentes
                {
                    return;
                }
                MainViewModel.GetInstance().Inicio = new InicioViewModel();

                this.MainPage = new MasterPage();

            }
        }


        protected override void OnStart ()
		{
            //Manejar cuando comienza tu aplicación

        }

        protected override void OnSleep ()
		{
            // Manejar cuando tu aplicación duerme
        }

        protected override void OnResume ()
		{
            // Manejar cuando su aplicación se reanude

        }
	}
}
