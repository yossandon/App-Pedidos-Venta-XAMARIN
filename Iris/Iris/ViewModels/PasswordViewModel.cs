namespace Pedidos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Models;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class PasswordViewModel : BaseViewModel
    {
        #region Attributes
        private bool isRunning;
        private bool isEnabled;
        private string passwordActual;
        private string passwordNueva;
        private string passwordConfirmar;
        #endregion

        #region Properties
        // El SetValue, sirve para que en tiempo de ejecución se refresque el valor
        // es decir, si hay un error y limpiamos la variable, esta vuelve al valor
        // inicial que se le asigno, ejemplo "Ingrese Pasword"

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        public string Nombre { get; set; }

        public string PasswordActual
        {
            get { return this.passwordActual; }
            set { SetValue(ref this.passwordActual, value); }
        }

        public string PasswordNueva
        {
            get { return this.passwordNueva; }
            set { SetValue(ref this.passwordNueva, value); }
        }
        public string PasswordConfirmar
        {
            get { return this.passwordConfirmar; }
            set { SetValue(ref this.passwordConfirmar, value); }
        }
       
        #endregion

        #region Constructors
        public PasswordViewModel()
        {
            this.IsEnabled = true;
            this.Nombre = Variables_Globales.Nombre_Usuario;
        }
        #endregion
         #region Commands
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(Register);
            }
        }

        private async void Register()
        {
            if (string.IsNullOrEmpty(this.PasswordActual))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "Debe Ingresar Password Actual", 
                    "Aceptar");
                return;
            }
            if (this.PasswordActual.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Password debe ser a lo menos 4 caractéres",
                    "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.PasswordActual = string.Empty;
                return;
            }
            var Clave_Desencriptada_de_BD = Encrypt.DecryptString(Variables_Globales.Password, "23Fr56t34pT");
            if(Clave_Desencriptada_de_BD != this.PasswordActual)
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Password No corresponde",
                   "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.PasswordActual = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordNueva))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe Ingresar Password Nueva",
                    "Aceptar");
                return;
            }
            if (this.PasswordNueva.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Password debe ser a lo menos 4 caracteres",
                    "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.PasswordNueva = string.Empty;
                return;
            }
            if (this.PasswordNueva == this.PasswordActual)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Password debe ser distina a la actual",
                    "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.PasswordNueva = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordConfirmar))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe Confirmar Password",
                    "Aceptar");
                return;
            }
            if (this.PasswordNueva != this.PasswordConfirmar)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Password no coincide a  la registrada",
                    "Aceptar");
                this.IsRunning = false;
                this.isEnabled = true;
                this.PasswordConfirmar = string.Empty;
                              return;
            }

            var Clave_Encriptada = Encrypt.EncryptString(this.PasswordNueva, "23Fr56t34pT");
            BaseDatos.Modificar_Password_Empleado(Variables_Globales.Usuario, Clave_Encriptada);
            await Application.Current.MainPage.DisplayAlert(
                    "Información",
                    "Actualización exitósa",
                    "Aceptar");

             Application.Current.MainPage = new MasterPage();
        }

        public ICommand AnteriorCommand
        {
            get
            {
                return new RelayCommand(Anterior);
            }
        }

        private void Anterior()
        {
            Application.Current.MainPage = new MasterPage();
        }
        #endregion
    }
}
