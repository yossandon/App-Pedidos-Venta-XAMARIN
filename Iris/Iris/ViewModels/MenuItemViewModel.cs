namespace Pedidos.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class MenuItemViewModel : BaseViewModel
    {
        #region Attributes
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        public String Icon
        {
            get;
            set;
        }
        public String PageName
        {
            get;
            set;
        }
        public String Title
        {
            get;
            set;
        }
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }
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
        #endregion

        private void Navigate()
        {
            // Acá se manda a los diferentes PAGE, dependiendo lo que seleccionó el Usurio 

            if (this.PageName == "PasswordPage")
            {
                MainViewModel.GetInstance().Password = new PasswordViewModel();
                Application.Current.MainPage = new PasswordPage();
            }
            if (this.PageName == "LoginPage")
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }
        }

        private void Finish()
        {
            Finish();
        }
    }
}
