using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Pedidos.Models;
using Pedidos.Services;

namespace Pedidos.ViewModels
{
    public class PedidosViewModel : BaseViewModel
    {

        #region Attributes
        private bool isVisible;
        private bool isRunning;
        #endregion
        #region Properties
        public bool IsVisible
        {
            get { return this.isVisible; }
            set { SetValue(ref this.isVisible, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        #endregion
        #region Constructors
        public PedidosViewModel()
        {
            this.IsVisible = false;
            if (Variables_Globales.Id_Comanda != 0)
            {
                BaseDatos.Totaliza_Detalle_Comandas_APP(Variables_Globales.Id_Comanda);
                if (Variables_Globales.Total_Cuenta != 0)
                {
                    this.IsVisible = true;
                    return;
                }
            }
            return;
        }
        #endregion
    }

}
