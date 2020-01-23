using GalaSoft.MvvmLight.Command;
using Pedidos.Models;
using Pedidos.Services;
using System.Windows.Input;
using Xamarin.Forms;
using Pedidos.Helpers;


namespace Pedidos.ViewModels
{
    public class RestauranteViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private bool isVisible;
        private bool isRunning;
        #endregion

        #region Properties
        public bool IsVisible
        {
            get  { return this.isVisible; }
            set { SetValue(ref this.isVisible, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        #endregion
        #region Constructors
        #region Command
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Categorias);
            }
        }
        private void Categorias()
        {
            this.IsRunning = true;

        }

        #endregion
        public RestauranteViewModel()
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
        #region Command

     
        #endregion
    }


}
