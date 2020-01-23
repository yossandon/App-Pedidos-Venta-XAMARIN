using GalaSoft.MvvmLight.Command;
using Pedidos.Models;
using Pedidos.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pedidos.ViewModels
{
    public class InicioViewModel : BaseViewModel
    {
        #region Attributes
        private bool isVisible;
        private bool isRunning;
        private bool isRefreshing;
       
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
        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion
        #region Constructors
        #region Command
        //public ICommand LoginCommand => new RelayCommand(Restaurante);
        
        #endregion

        public InicioViewModel()
        {
            this.IsVisible = false;
            this.IsRefreshing = true;
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
