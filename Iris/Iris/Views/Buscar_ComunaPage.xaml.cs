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
	public partial class Buscar_ComunaPage : ContentPage
	{
		public Buscar_ComunaPage ()
		{
			InitializeComponent ();
            lsvComunas.ItemsSource = BaseDatos.Trae_Comunas(Variables_Globales.Id_Ciudad_Cliente_Nueva, "%");
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
            Variables_Globales.Id_Comuna_Cliente_Nueva = Convert.ToInt32(button.CommandParameter.ToString());
            BaseDatos.Trae_Descripcion_Comuna_x_ID(Variables_Globales.Id_Comuna_Cliente_Nueva);
            await App.Navigator.PopAsync(true);
        }
        private void MainSearchBar_OnSearchButtonProssed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;
            lsvComunas.ItemsSource = BaseDatos.Trae_Comunas(Variables_Globales.Id_Ciudad_Cliente_Nueva, "%" + keyword + "%");
        }
    }
}