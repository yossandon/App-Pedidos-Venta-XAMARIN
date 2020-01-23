using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.Models;
using Pedidos.ViewModels;
using Acr.UserDialogs;
using System.ComponentModel;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestaurantePage : ContentPage
	{
		public RestaurantePage ()
		{
			InitializeComponent ();
            
        }
        async protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            // Acá se esta cargando en la página, la lista de todas las Categorías
            base.OnAppearing();
            this.lsvCategorias.ItemsSource = Variables_Globales.Lista_Catgeorias;
            this.lsvArticulos.ItemsSource = Variables_Globales.Lista_Articulos;
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
        void btnrcategoria(Object Sender, EventArgs args)
        {
            Button button = (Button)Sender;
            Variables_Globales.Categroia = button.CommandParameter.ToString();
            lsvArticulos.ItemsSource = BaseDatos.Llenar_Lista_con_Articulos_x_Categoria(Variables_Globales.Categroia);
        }
        async void Agregar_Recomendacion(Object Sender, EventArgs args)
        {
            Button button = (Button)Sender;
            Variables_Globales.Codigo = button.CommandParameter.ToString();
            MainViewModel.GetInstance().Pedidos = new PedidosViewModel();
            await App.Navigator.PushAsync(new PedidoPage());
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