using Pedidos.Models;
using Pedidos.ViewModels;
using System;
using System.Data;
using System.Data.SqlClient;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PedidoPage : ContentPage
	{
		public PedidoPage ()
		{
			InitializeComponent ();
            Variables_Globales.Cantidad = 1;
            Variables_Globales.Articulos_Agregados = "";
            txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);
            Variables_Globales.ToTal_Venta_Articulo = 0;
            Variables_Globales.Mensaje = "";
            Variables_Globales.Tiene_Agregados_y_Selecciono = false;
        }
        async protected override void OnAppearing()
        {
            // Acá se esta cargando en la página, 
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            base.OnAppearing();
            if (Variables_Globales.Tiene_Agregados_y_Selecciono == true )
            {
                this.txtMensaje.Text = this.txtMensaje.Text + " " + Variables_Globales.Articulos_Agregados;
                if (Variables_Globales.Id_Comanda == 0 && Variables_Globales.Id_Mesa == 0)
                {
                    BaseDatos.Trae_Correlativo_Delivery_e_Incrementa();  // Se obtiene una Id_Mesa Virtual
                    BaseDatos.AgregarComanda(Variables_Globales.Nombre_Cliente, Variables_Globales.Id_Mesa);
                    BaseDatos.Obtener_Id_Comanda(Variables_Globales.Id_Garzon, Variables_Globales.Id_Mesa);
                }
                if (txtMensaje.Text is null)
                {
                    Variables_Globales.Mensaje = "";
                }
                else
                {
                    Variables_Globales.Mensaje = this.txtMensaje.Text;
                }

                Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
                Variables_Globales.Descuento = 0;
                BaseDatos.Agregar_DetalleComanda(Variables_Globales.Codigo,
                                                 Variables_Globales.Descuento,
                                                 Variables_Globales.ToTal_Venta_Articulo,
                                                 Variables_Globales.Mensaje,
                                                 Variables_Globales.Id_Comanda,
                                                 Variables_Globales.Cantidad);
                Variables_Globales.ToTal_Venta_Articulo = 0;
                Variables_Globales.Total_Cuenta = 1;
                Variables_Globales.Mensaje = "";
                await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            lsvArticulo.ItemsSource = BaseDatos.Trae_Articulo_APP(Variables_Globales.Id_Empresa,Variables_Globales.Codigo );
            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
            this.txtTotalVentaArticulo.Text = "Agregar al Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
        }
        async void Agregar_Pedido(Object Sender, EventArgs args)
        {
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

            this.txtMensaje.Text = this.txtMensaje.Text + " " + Variables_Globales.Articulos_Agregados;
            if (Variables_Globales.Id_Comanda == 0 && Variables_Globales.Id_Mesa == 0)
            {
                BaseDatos.Trae_Correlativo_Delivery_e_Incrementa();  // Se obtiene una Id_Mesa Virtual
                BaseDatos.AgregarComanda(Variables_Globales.Nombre_Cliente, Variables_Globales.Id_Mesa);
                BaseDatos.Obtener_Id_Comanda(Variables_Globales.Id_Garzon, Variables_Globales.Id_Mesa);
            }
            if (txtMensaje.Text is null)
            {
                Variables_Globales.Mensaje = "";
            }
            else
            {
                Variables_Globales.Mensaje = this.txtMensaje.Text;
            }

            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
            Variables_Globales.Descuento = 0;
            BaseDatos.Agregar_DetalleComanda(Variables_Globales.Codigo,
                                             Variables_Globales.Descuento,
                                             Variables_Globales.ToTal_Venta_Articulo,
                                             Variables_Globales.Mensaje,
                                             Variables_Globales.Id_Comanda,
                                             Variables_Globales.Cantidad);
            Variables_Globales.ToTal_Venta_Articulo = 0;
            Variables_Globales.Mensaje = "";
            await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior

        }
        void Resta(Object Sender, EventArgs args)
        {
            if (Variables_Globales.Cantidad != 1)
            {
                Variables_Globales.Cantidad = Variables_Globales.Cantidad - 1;
                txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);
                Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta * Variables_Globales.Cantidad;
                this.txtTotalVentaArticulo.Text = "Agregar al Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
            }
            return;
        }
        void Suma(Object Sender, EventArgs args)
        {
            Variables_Globales.Cantidad = Variables_Globales.Cantidad + 1;
            txtCantidad.Text = String.Format("{0:N0}", Variables_Globales.Cantidad);
            Variables_Globales.ToTal_Venta_Articulo = Variables_Globales.Precio_Venta *  Variables_Globales.Cantidad;
            this.txtTotalVentaArticulo.Text = "Agregar al Pedido ($" + String.Format("{0:N0}", Variables_Globales.ToTal_Venta_Articulo) + ")";
            return;
        }
       
        // void Enviar_Pedido(Object Sender, EventArgs args)
        //{
        //    if (Variables_Globales.Id_Comanda != 0 && Variables_Globales.Id_Mesa != 0)
        //    {
        //        BaseDatos.Modificar_Estado_Comanda(Variables_Globales.Id_Comanda, 514);
        //        Variables_Globales.Id_Comanda = 0;
        //        Variables_Globales.Id_Mesa = 0;
        //        Variables_Globales.ToTal_Venta_Articulo = 0;
        //        Variables_Globales.Mensaje = "";
        //    }
        //}
    }
}