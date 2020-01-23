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
	public partial class Pago_OnLinePage : ContentPage
	{
		public Pago_OnLinePage ()
		{
			InitializeComponent ();
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
            await App.Navigator.PushAsync(new Direccion_EnvioPage());

            //    --->     Validaciones

            //    if (txtApodo.Text is null)
            //    {
            //        await Application.Current.MainPage.DisplayAlert(
            //            "Información",
            //            "Debe Ingresar Apodo",
            //            "Aceptar");
            //    }
            //    else
            //    {
            //        if (txtCalle.Text is null)
            //        {
            //            await Application.Current.MainPage.DisplayAlert(
            //                "Información",
            //               "Debe Ingresar Calle",
            //                "Aceptar");
            //        }
            //        else
            //        {
            //            if (txtNumero.Text is null)
            //            {
            //                await Application.Current.MainPage.DisplayAlert(
            //                    "Información",
            //                   "Debe Ingresar Número",
            //                    "Aceptar");
            //            }
            //            else
            //            {
            //                if (txtCiudad.Text is null)
            //                {
            //                    await Application.Current.MainPage.DisplayAlert(
            //                        "Información",
            //                       "Debe Ingresar Ciudad",
            //                        "Aceptar");
            //                }
            //                else
            //                {
            //                    if (txtComuna.Text is null)
            //                    {
            //                        await Application.Current.MainPage.DisplayAlert(
            //                            "Información",
            //                           "Debe Ingresar Comuna",
            //                            "Aceptar");
            //                    }
            //                    else
            //                    {
            //                        if (txtComuna.Text is null)
            //                        {
            //                            await Application.Current.MainPage.DisplayAlert(
            //                                "Información",
            //                               "Debe Ingresar Comuna",
            //                                "Aceptar");
            //                        }
            //                        else
            //                        {
            //                            if (txtReferencia.Text is null)
            //                            {
            //                                txtReferencia.Text = "Sin Referencia";
            //                            }
            //                            else
            //                            {
            //                                if (txtTelefono.Text is null)
            //                                {
            //                                    await Application.Current.MainPage.DisplayAlert(
            //                                        "Información",
            //                                       "Debe Ingresar Teléfono",
            //                                        "Aceptar");
            //                                }
            //                                else
            //                                {
            //                                    BaseDatos.Agregar_Direccion_Cliente(
            //                                          Variables_Globales.Id_Cliente,
            //                                          txtApodo.Text, txtCalle.Text + " " + txtNumero.Text,
            //                                          Variables_Globales.Id_Ciudad_Cliente_Nueva,
            //                                          Variables_Globales.Id_Comuna_Cliente_Nueva,
            //                                          txtReferencia.Text,
            //                                          txtTelefono.Text);
            //                                    await App.Navigator.PopAsync(true);
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }

        }
    }
}