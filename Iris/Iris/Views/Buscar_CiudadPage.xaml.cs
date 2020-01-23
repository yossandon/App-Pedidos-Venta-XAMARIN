using Pedidos.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Buscar_CiudadPage : ContentPage
	{
		public Buscar_CiudadPage ()
		{
			InitializeComponent ();
            Variables_Globales.Id_Ciudad_Cliente_Nueva = 0;
            Variables_Globales.Ciudad_Cliente_Nueva = "";
            Variables_Globales.Comuna_Cliente_Nueva = "";
            lsvCiudades.ItemsSource = BaseDatos.Trae_Ciudades("%");
        }
        async protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
        }
        async void Seleccionar(Object Sender, EventArgs args)
        {
            Button button = (Button)Sender;
            Variables_Globales.Id_Ciudad_Cliente_Nueva = Convert.ToInt32(button.CommandParameter.ToString());
            BaseDatos.Trae_Descripcion_Ciudad_x_ID(Variables_Globales.Id_Ciudad_Cliente_Nueva);
            await App.Navigator.PopAsync(true);
        }
        private void MainSearchBar_OnSearchButtonProssed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;
            lsvCiudades.ItemsSource = BaseDatos.Trae_Ciudades("%" + keyword + "%");
        }
    }
}