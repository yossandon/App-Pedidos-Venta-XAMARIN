using Pedidos.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallePedidosPage : ContentPage
	{
		public DetallePedidosPage ()
		{
			InitializeComponent ();
		}
        async protected override void OnAppearing()
        {
            // Acá se esta cargando en la página, 
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            base.OnAppearing();
            lsvDetallePedido.ItemsSource = BaseDatos.Trae_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
            BaseDatos.Totaliza_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
           
            if (Variables_Globales.Total_Cuenta != 0)
            {
                txtTotalVentaArticulo.Text = "Total $" + String.Format("{0:N0}", Variables_Globales.Total_Cuenta) + "     Enviar Pedido";
                txtTotalVentaArticulo.IsVisible = true;
            }
            else
            {
                txtTotalVentaArticulo.IsVisible = false;
            }
        }
        async void Modificar(Object Sender, EventArgs args)
        {
           
            Button button = (Button)Sender;
            Variables_Globales.Id_Detalle_Comanda = Convert.ToInt32(button.CommandParameter.ToString());
            await App.Navigator.PushAsync(new ModificarPedidoPage());

        }
        async void Enviar_Pedido(Object Sender, EventArgs args)
        {
           
            await App.Navigator.PushAsync(new FormaPagoPage());
        }
        private void startPanic(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                txtTotalVentaArticulo.IsVisible = false;
            }
            );
        }
    }
}