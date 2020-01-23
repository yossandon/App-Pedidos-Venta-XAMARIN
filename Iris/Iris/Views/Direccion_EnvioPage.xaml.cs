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
	public partial class Direccion_EnvioPage : ContentPage
	{
		public Direccion_EnvioPage ()
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
            // Acá se esta cargando en la página, 
            txtApodo.Text = Variables_Globales.Apodo_Cliente;
            txtDireccion.Text = Variables_Globales.Direccion_Cliente + ", " + Variables_Globales.Comuna_Cliente + ", " + Variables_Globales.Ciudad_Cliente;
            BaseDatos.Trae_Descripcion_Forma_Pago(Variables_Globales.Id_Forma_Pago);
            txtFormaPago.Text = Variables_Globales.Descripcion_Forma_pago;
            txtMontoCancela.Text = "----";
            txtVuelto.Text = "----";
            if (Variables_Globales.Id_Forma_Pago == 4)
            {
                txtMontoCancela.Text = "$" + String.Format("{0:N0}", Variables_Globales.Monto_Cancela);
                txtVuelto.Text = "$" + String.Format("{0:N0}", Variables_Globales.Monto_Cancela - (Variables_Globales.Total_Cuenta + Variables_Globales.Costo_Envio));
            }
        }
        async void Editar_Direccion(Object Sender, EventArgs args)
        {
            await App.Navigator.PushAsync(new Editar_DireccionesPage());
            return;

        }
        async void EnviarPedido(Object Sender, EventArgs args)
        {
            if (Variables_Globales.Id_Comanda != 0 && Variables_Globales.Id_Mesa != 0)
            {
                if (Variables_Globales.Total_Cuenta != 0)
                {
                    BaseDatos.Modificar_Estado_Comanda(Variables_Globales.Id_Comanda, 514);
                    BaseDatos.Agregar_Rutas_Despacho(Variables_Globales.Id_Comanda,
                                                txtDireccion.Text, txtDireccion.Text,
                                                Variables_Globales.Monto_Cancela, 
                                                Variables_Globales.Monto_Cancela - (Variables_Globales.Total_Cuenta + Variables_Globales.Costo_Envio));
                    if (txtMensaje.Text is null)
                    {
                        txtMensaje.Text = "";
                    }
                    
                    BaseDatos.Crear_Envio_APP(Variables_Globales.Id_Comanda, 601, Variables_Globales.Id_Forma_Pago, txtMensaje.Text);
                    txtMensaje.Text = "";
                    Variables_Globales.Id_Forma_Pago = 0;
                    Variables_Globales.Id_Comanda = 0;
                    Variables_Globales.Monto_Cancela = 0;
                    Variables_Globales.Id_Mesa = 0;
                    Variables_Globales.ToTal_Venta_Articulo = 0;
                    Variables_Globales.Mensaje = "";
                    Variables_Globales.Total_Cuenta = 0;
                    Variables_Globales.Realizo_Venta = true;
                    bool confirm = await Application.Current.MainPage.DisplayAlert(
                          "Información",
                          "Gracias ...¿Desea realizar otro pedido?",
                          "Si",
                          "No");
                    if (confirm)
                        {
                            await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
                        }
                        else
                        {
                            // Con esto termino mi APP y sale
                            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                        }
                    }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(
                    "Información",
                    "Su pedido no tiene productos a enviar",
                    "Aceptar");
                    return;
                }
            }

        }
    }
}