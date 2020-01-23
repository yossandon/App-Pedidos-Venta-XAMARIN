using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.Models;
using Pedidos.ViewModels;
using System;
namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModificarPedidoPage : ContentPage
	{
		public ModificarPedidoPage ()
		{
			InitializeComponent ();
            Variables_Globales.Tiene_Agregados_y_Selecciono = false;
            Variables_Globales.Articulos_Agregados = "";
            this.txtMensaje.Text = "";
        }
       async protected override void OnAppearing()
        {
            // Acá se esta cargando en la página, 
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            base.OnAppearing();
            if (Variables_Globales.Tiene_Agregados_y_Selecciono == true)
            {
                this.txtMensaje.Text = this.txtMensaje.Text + " + " + Variables_Globales.Articulos_Agregados;
                Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
                Variables_Globales.Descuento = 0;
                BaseDatos.Modificar_Detalle_Comanda(Variables_Globales.Id_Detalle_Comanda,
                                             Variables_Globales.Cantidad,
                                             this.txtMensaje.Text,
                                             Variables_Globales.ToTal_Venta_Articulo);
                Variables_Globales.ToTal_Venta_Articulo = 0;
                Variables_Globales.Mensaje = "";
                await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            lsvArticulo.ItemsSource = BaseDatos.Trae_Detalle_Pedido_x_ID(Variables_Globales.Id_Detalle_Comanda);
            txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);

            BaseDatos.Trae_Codigo_Detalle_Comanda(Variables_Globales.Id_Detalle_Comanda);
            BaseDatos.Trae_Id_Articulo_x_Codigo(Variables_Globales.Codigo);
            BaseDatos.Verifica_si_Tiene_Agregados(Variables_Globales.Id_Articulo);
            if (Variables_Globales.Tiene_Agregados == true)
            {
                txtMensaje.Text = "";    // Variables_Globales.Observacion);
            }
            else
            {
                txtMensaje.Text = Variables_Globales.Observacion;
            }

            
            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
            this.txtTotalVentaArticulo.Text = "Modificar Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
        }
        void Eliminar(Object Sender, EventArgs args)
        {
            if (Variables_Globales.Cantidad != 1)
            {
                Variables_Globales.Cantidad = Variables_Globales.Cantidad - 1;
                txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);
                Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
                this.txtTotalVentaArticulo.Text = "Modificar Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
            }
            return;
        }
        void Agregar(Object Sender, EventArgs args)
        {
            Variables_Globales.Cantidad = Variables_Globales.Cantidad + 1;
            txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);
            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
            this.txtTotalVentaArticulo.Text = "Modificar Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
            return;
        }
        async void Mofificar_Pedido(Object Sender, EventArgs args)
        {
            BaseDatos.Trae_Codigo_Detalle_Comanda(Variables_Globales.Id_Detalle_Comanda);
            BaseDatos.Trae_Id_Articulo_x_Codigo(Variables_Globales.Codigo);
            BaseDatos.Verifica_si_Tiene_Agregados(Variables_Globales.Id_Articulo);
            if (Variables_Globales.Tiene_Agregados == true)
            {
                BaseDatos.Trae_de_Cantidad_Agregados_Id_Cantidad_Agregados_y_N_Solicitud(Variables_Globales.Id_Articulo);
                if (Variables_Globales.N_Solicitud_1 != 0)
                {
                    await App.Navigator.PushAsync(new Agregar_IngredientesPage(Variables_Globales.N_Solicitud_1,
                        Variables_Globales.Id_Cantidad_Agregados_1), false);
                    return;
                }
            }
            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
            if (txtMensaje.Text is null)
            {
                Variables_Globales.Mensaje = "";
            }
            else
            {
                Variables_Globales.Mensaje = this.txtMensaje.Text;
            }
            BaseDatos.Modificar_Detalle_Comanda(Variables_Globales.Id_Detalle_Comanda,
                                             Variables_Globales.Cantidad,
                                             Variables_Globales.Mensaje,
                                             Variables_Globales.ToTal_Venta_Articulo);
            Variables_Globales.ToTal_Venta_Articulo = 0;
            Variables_Globales.Mensaje = "";
            await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior

        }
        async void Elimina_Producto(Object Sender, EventArgs args)
        {
            bool confirm = await Application.Current.MainPage.DisplayAlert(
                     "Información",
                     "¿Esta seguro de eliminar Producto?",
                     "Si",
                     "No");
            if (confirm)
            {
                BaseDatos.Eliminar_Detalle_Comanda(Variables_Globales.Id_Detalle_Comanda);
                Variables_Globales.ToTal_Venta_Articulo = 0;
                Variables_Globales.Mensaje = "";
                await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
        }
    }
}