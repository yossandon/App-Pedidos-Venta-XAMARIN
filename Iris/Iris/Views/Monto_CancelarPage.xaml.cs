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
	public partial class Monto_CancelarPage : ContentPage
	{
		public Monto_CancelarPage ()
		{
			InitializeComponent ();
            BaseDatos.Totaliza_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
            txtSubtotal.Text = "$" + String.Format("{0:N0}", Variables_Globales.Total_Cuenta);
            txtEnvio.Text = "$" + String.Format("{0:N0}", Variables_Globales.Costo_Envio);
            txtTotal.Text = "$" + String.Format("{0:N0}", Variables_Globales.Total_Cuenta + Variables_Globales.Costo_Envio);
        }
        async protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
        }
        async void Continuar(Object Sender, EventArgs args)
        {
            if (txtMonto.Text is null)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Información",
                    "Debe Ingresar Monto",
                    "Aceptar");
            }
            else
            {
                if (Convert.ToInt32(txtMonto.Text) < (Variables_Globales.Total_Cuenta + Variables_Globales.Costo_Envio))
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Información",
                        "Monto ingresado insuficiente",
                        "Aceptar");
                }
                else
                {
                    Variables_Globales.Monto_Cancela = Convert.ToInt32(txtMonto.Text);
                    await App.Navigator.PushAsync(new Direccion_EnvioPage());
                }
            }
        }

    }
}