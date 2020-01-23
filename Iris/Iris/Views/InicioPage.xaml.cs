using Pedidos.Models;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.Views;
using System;
using Pedidos.ViewModels;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioPage : ContentPage
	{
		public InicioPage ()
		{
			InitializeComponent ();
            btnrestaurantes.Clicked += Btnrestaurantes_Clicked;
            Variables_Globales.Realizo_Venta = false;
        }
        protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
                    Variables_Globales.Realizo_Venta = false;
                    Variables_Globales.Total_Cuenta = 0;
                    Variables_Globales.Id_Comanda = 0;
            }

            base.OnAppearing();
            this.lsvArticulos.ItemsSource = Variables_Globales.Lista_Articulos_Recomendados;
            Variables_Globales.Categroia = Variables_Globales.Categroia_1;
            BaseDatos.Totaliza_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
            if (Variables_Globales.Total_Cuenta != 0)
            {
               BaseDatos.Totaliza_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
               txtTotalCuenta.Text = "Total $" + String.Format("{0:N0}", Variables_Globales.Total_Cuenta) + "     Ver/Modificar su Pedido";
               txtTotalCuenta.IsVisible = true;
            }
            else
            {
                txtTotalCuenta.IsVisible = false;
            }
        }
        async void Agregar_Recomendacion(Object Sender, EventArgs args)
        {
            Button button = (Button)Sender;
            Variables_Globales.Codigo = button.CommandParameter.ToString();
            MainViewModel.GetInstance().Pedidos = new PedidosViewModel();
            await App.Navigator.PushAsync(new PedidoPage());
            return;
        }
        private async void Btnrestaurantes_Clicked(object sender, EventArgs e)
        {
            // La línea siguiente es para INTANCIAR el View con el ViewModel, de tal forma
            // que se puedan realizar las validaciones correspondiente en la ViewModel

            MainViewModel.GetInstance().Restaurante = new RestauranteViewModel();
            await App.Navigator.PushAsync(new RestaurantePage());
        }
        async void Detalle(Object Sender, EventArgs args)
        {
            await App.Navigator.PushAsync(new DetallePedidosPage());
            return;
        }
        private void startPanic(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                txtTotalCuenta.IsVisible = false;
            });
        }
    }
}