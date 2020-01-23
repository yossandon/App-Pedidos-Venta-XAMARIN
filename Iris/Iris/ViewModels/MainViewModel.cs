namespace Pedidos.ViewModels
{
    using Pedidos.Models;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class MainViewModel
    {

        #region ViewModels

        // Corresponde a --> BindingContext="{Binding Restaurante}" del RestaurantePage.xaml
        // esto se debe hacer para todos los ViewModel que creemos

        public RestauranteViewModel Restaurante
        {
            get;
            set;    
        }
        public InicioViewModel Inicio
        {
            get;
            set;

        }
        public PedidosViewModel Pedidos
        {
            get;
            set;
        }
        public LoginViewModel Login
        {
            get;
            set;
        }
        public PasswordViewModel Password
        {
            get;
            set;
        }
        #endregion
        #region Properties

        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }
       
        public string Token
        {
            get;
            set;
        }
        public string TokenType
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
      
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "Password",
                PageName = "PasswordPage",
                Title = "Cambiar Password"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "Salir",
                PageName = "LoginPage",
                Title = "Salir"
            });
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
