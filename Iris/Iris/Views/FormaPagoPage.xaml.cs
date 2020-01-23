using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pedidos.Models;
using Pedidos.ViewModels;
using System;

namespace Pedidos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormaPagoPage : ContentPage
	{
		public FormaPagoPage ()
		{
			InitializeComponent ();
		}
        async protected override void OnAppearing()
        {
            if (Variables_Globales.Realizo_Venta == true)
            {
               await App.Navigator.PopAsync(true);  //--> Para retornar a la pantalla anterior
            }
            base.OnAppearing();
            lsvFormaPago.ItemsSource = BaseDatos.Trae_Forma_Pago(Variables_Globales.Id_Empresa);
        }
        async void Selecciona(Object Sender, EventArgs args)
        {

            Button button = (Button)Sender;
            Variables_Globales.Id_Forma_Pago = Convert.ToInt32(button.CommandParameter.ToString());
            //1   =  Pago On Line    
            //2   =  Tarjeta Crédito 
            //3   =  Tarjeta Débito  
            //4   =  Efectivo    
            //5   =  Vales   
            Variables_Globales.Monto_Cancela = (Variables_Globales.Total_Cuenta + Variables_Globales.Costo_Envio);
            if (Variables_Globales.Id_Forma_Pago == 4)
            {
                await App.Navigator.PushAsync(new Monto_CancelarPage());
            }
            else
            {
                if (Variables_Globales.Id_Forma_Pago == 1)
                {
                    await App.Navigator.PushAsync(new Pago_OnLinePage());
                }
                else
                {
                    await App.Navigator.PushAsync(new Direccion_EnvioPage());
                }
            }
        }
    }
}