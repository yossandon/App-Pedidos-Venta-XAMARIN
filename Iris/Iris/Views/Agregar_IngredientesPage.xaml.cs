using Pedidos.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.ViewModels;
using Acr.UserDialogs;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Agregar_IngredientesPage : ContentPage
	{
		public Agregar_IngredientesPage (int N_Solicitud, int Id_Cantidad_Agregados)
		{
			InitializeComponent ();
            Variables_Globales.Articulos_Agregados = "";
            BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, N_Solicitud);
            Variables_Globales.Cantidad_a_Mensaje = "";
            Variables_Globales.Tiene_Agregados_y_Selecciono = false;
            Variables_Globales.Cantidad_Agregados_seleccionados = 0;
            if (Variables_Globales.Cantidad_Agregados != 0)
            {
                Variables_Globales.Cantidad_a_Mensaje = " (" + Variables_Globales.Cantidad_Agregados + ")";
            }
            txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
            lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Id_Cantidad_Agregados);
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
            if (txtIngredientes.Text is null)
            {
                Variables_Globales.Mensaje_Suma = "";
            }
            else
            {
                Variables_Globales.Mensaje_Suma = " + ";
            }
            txtIngredientes.Text = txtIngredientes.Text + Variables_Globales.Mensaje_Suma + button.CommandParameter.ToString();
            Variables_Globales.Articulos_Agregados = txtIngredientes.Text;
            Variables_Globales.Cantidad_Agregados_seleccionados = Variables_Globales.Cantidad_Agregados_seleccionados + 1;
           
            if (Variables_Globales.Cantidad_Agregados_seleccionados == Variables_Globales.Cantidad_Agregados)
            {
                Variables_Globales.N_Solicitud_1 = 0;
                Variables_Globales.Id_Cantidad_Agregados_1 = 0;
                if (Variables_Globales.N_Solicitud_2 != 0)
                {
                    BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_2);
                    Variables_Globales.Cantidad_a_Mensaje = "";
                    Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                    if (Variables_Globales.Cantidad_Agregados != 0)
                    {
                        Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                    }
                    txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                    lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_2);
                    Variables_Globales.N_Solicitud_2 = 0;
                    Variables_Globales.Id_Cantidad_Agregados_2 = 0;
                }
                else
                {
                    if (Variables_Globales.N_Solicitud_3 != 0)
                    {
                        BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_3);
                        Variables_Globales.Cantidad_a_Mensaje = "";
                        Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                        if (Variables_Globales.Cantidad_Agregados != 0)
                        {
                            Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                        }
                        txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                        lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_3);
                        Variables_Globales.N_Solicitud_3 = 0;
                        Variables_Globales.Id_Cantidad_Agregados_3 = 0;
                    }
                    else
                    {
                        if (Variables_Globales.N_Solicitud_4 != 0)
                        {
                            BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_4);
                            Variables_Globales.Cantidad_a_Mensaje = "";
                            Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                            if (Variables_Globales.Cantidad_Agregados != 0)
                            {
                                Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                            }
                            txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                            lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_4);
                            Variables_Globales.N_Solicitud_4 = 0;
                            Variables_Globales.Id_Cantidad_Agregados_4 = 0;
                        }
                        else
                        {
                            if (Variables_Globales.N_Solicitud_5 != 0)
                            {
                                BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_5);
                                Variables_Globales.Cantidad_a_Mensaje = "";
                                Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                if (Variables_Globales.Cantidad_Agregados != 0)
                                {
                                    Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                }
                                txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_5);
                                Variables_Globales.N_Solicitud_5 = 0;
                                Variables_Globales.Id_Cantidad_Agregados_5 = 0;
                            }
                            else
                            {
                                if (Variables_Globales.N_Solicitud_6 != 0)
                                {
                                    BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_6);
                                    Variables_Globales.Cantidad_a_Mensaje = "";
                                    Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                    if (Variables_Globales.Cantidad_Agregados != 0)
                                    {
                                        Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                    }
                                    txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                    lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_6);
                                    Variables_Globales.N_Solicitud_6 = 0;
                                    Variables_Globales.Id_Cantidad_Agregados_6 = 0;
                                }
                                else
                                {
                                    if (Variables_Globales.N_Solicitud_7 != 0)
                                    {
                                        BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_7);
                                        Variables_Globales.Cantidad_a_Mensaje = "";
                                        Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                        if (Variables_Globales.Cantidad_Agregados != 0)
                                        {
                                            Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                        }
                                        txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                        lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_7);
                                        Variables_Globales.N_Solicitud_7 = 0;
                                        Variables_Globales.Id_Cantidad_Agregados_7 = 0;
                                    }
                                    else
                                    {
                                        if (Variables_Globales.N_Solicitud_8 != 0)
                                        {
                                            BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_8);
                                            Variables_Globales.Cantidad_a_Mensaje = "";
                                            Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                            if (Variables_Globales.Cantidad_Agregados != 0)
                                            {
                                                Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                            }
                                            txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                            lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_8);
                                            Variables_Globales.N_Solicitud_8 = 0;
                                            Variables_Globales.Id_Cantidad_Agregados_8 = 0;
                                        }
                                        else
                                        {
                                            if (Variables_Globales.N_Solicitud_9 != 0)
                                            {
                                                BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_9);
                                                Variables_Globales.Cantidad_a_Mensaje = "";
                                                Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                                if (Variables_Globales.Cantidad_Agregados != 0)
                                                {
                                                    Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                                }
                                                txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                                lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_9);
                                                Variables_Globales.N_Solicitud_9 = 0;
                                                Variables_Globales.Id_Cantidad_Agregados_9 = 0;
                                            }
                                            else
                                            {
                                                if (Variables_Globales.N_Solicitud_10 != 0)
                                                {
                                                    BaseDatos.Trae_Cantidad_Mensaje_de_Agregados(Variables_Globales.Id_Articulo, Variables_Globales.N_Solicitud_10);
                                                    Variables_Globales.Cantidad_a_Mensaje = "";
                                                    Variables_Globales.Cantidad_Agregados_seleccionados = 0;
                                                    if (Variables_Globales.Cantidad_Agregados != 0)
                                                    {
                                                        Variables_Globales.Cantidad_a_Mensaje = "(" + Variables_Globales.Cantidad_Agregados + ")";
                                                    }
                                                    txtMensaje.Text = Variables_Globales.Mensaje_Agregados + Variables_Globales.Cantidad_a_Mensaje;
                                                    lsvIngredientes.ItemsSource = BaseDatos.Trae_Agregados_Articulo(Variables_Globales.Id_Articulo, Variables_Globales.Id_Cantidad_Agregados_10);
                                                    Variables_Globales.N_Solicitud_10 = 0;
                                                    Variables_Globales.Id_Cantidad_Agregados_10 = 0;
                                                }
                                                else
                                                {
                                                    Variables_Globales.Tiene_Agregados_y_Selecciono = true;
                                                    await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        private void startPanic(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                //btnOK.setEnabled(false);
                //Boton.setBackgroundColor(Color.Blue);
                //this.Seleccionar.setBackgroundColor(Color.Blue);
            });
        }
    }
}