namespace Pedidos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Services;
    using Views;
    using Xamarin.Forms;
    using Pedidos.Models;
    using Pedidos.Helpers;
   
    public class LoginViewModel : BaseViewModel
    {
     
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private string usuario;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private bool isRefreshing;

        #endregion

        #region Properties
        public string Usuario
        {
            get { return this.usuario; }
            set { SetValue(ref this.usuario, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
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

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.apiService = new ApiService();
            this.IsRemembered = true;
            this.IsEnabled = true;
            // Mientras se realizan las pruebas
            //this.Usuario = "yossandon";
            //this.Password = "2507";
        }
        #endregion

        #region Command
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }
      
        private async void Login()
        {
            this.IsRefreshing = true;

            var connection = await apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Aceptar");
                //PopAsync ==== > Es igual que el usuario le de clic para atras, es decir se va al LOGIN
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }

            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Usted debe ingresar su Correo",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                        "Error",
                        "Usted debe ingresar una Password",
                        "Aceptar");
                return;
            }

            this.IsRunning = true;
            this.isEnabled = false;

            
            Variables_Globales.Usuario = string.Empty;
            BaseDatos.Trae_Datos_Cliente(usuario);
            if (this.Usuario != Variables_Globales.EMail_Cliente)
            {
                this.IsRunning = false;
                this.isEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                       "Información",
                       "Cliente no registrado",
                       "Aceptar");
                this.Password = string.Empty;
                return;
            }
            if (Variables_Globales.Estado_Cliente != 1)
            {
                this.IsRunning = false;
                this.isEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                       "Información",
                       "Ud. se encuentra bloqueado",
                       "Aceptar");
                this.Password = string.Empty;
                return;
            }
            var Clave_Desencriptada_de_BD = Encrypt.DecryptString(Variables_Globales.Password, "23Fr56t34pT");

            if (this.Password != Clave_Desencriptada_de_BD)
            {
                await Application.Current.MainPage.DisplayAlert(
                           "Información",
                           "Password ingresada Incorrecta",
                           "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.Password = string.Empty;
                return;
            }

            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.Token = this.usuario;
            mainViewModel.TokenType = this.Password;

            if (this.IsRemembered)
            {
                Settings.Token = this.usuario;
                Settings.TokenType = this.Password;
            }
            this.IsRunning = true;
            Variables_Globales.Color = "MediumSeaGreen";

            Application.Current.MainPage = new MasterPage();
           
        }

        public ICommand SalirCommand
        {
            get
            {
                return new RelayCommand(Salir);
            }
        }
        private void Salir()
        {
            Finish();
        }
        #endregion

        private void Finish()
        {
                       Finish();
        }

    }
}
