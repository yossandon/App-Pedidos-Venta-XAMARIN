using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Editar_DireccionesPage : ContentPage
	{
		public Editar_DireccionesPage ()
		{
			InitializeComponent ();
		}
        async protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            // Acá se esta cargando en la página, 
            base.OnAppearing();
            lsvDireccionesCliente.ItemsSource = BaseDatos.Trae_Direcciones_Cliente(Variables_Globales.Id_Cliente);
        }
        async void Seleccion(Object Sender, EventArgs args)
        {
            Button button = (Button)Sender;
            //Variables_Globales.EMail_Cliente = Convert.ToInt32 (button.CommandParameter.ToString());
            BaseDatos.Trae_Direccion_Cliente_x_ID(Convert.ToInt32(button.CommandParameter.ToString()));
            await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior

        }
        async void Direccion(Object Sender, EventArgs args)
        {
            await App.Navigator.PushAsync(new Agregar_DireccionPage());
        }
    }
}