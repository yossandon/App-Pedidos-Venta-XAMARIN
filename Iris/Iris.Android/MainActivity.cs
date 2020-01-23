namespace Pedidos.Droid
{
    using Acr.UserDialogs;
    using Android.App;
    using Android.Content;
    using Android.Content.PM;
    using Android.OS;
    using ZXing.Mobile;

    //MainActivity: 
    //Es un método que utiliza Android para iniciar una actividad instancia
    //in vocando los métodos específicos que corresponden a las etapas del ciclo de vida. 
    //Layout: Android organiza los componentes visuales (button, EditText, Textview,etc) 
    //en una pantalla mediante contenedores llamados Layout

    [Activity(Label = "Pedidos", 
        Icon = "@drawable/Iris", 
        Theme = "@style/MainTheme",
        MainLauncher = false, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //****************************************************************************
        // OnBackPressed --> se usa ara des habilitar el "para atras" del dispositivo
        //****************************************************************************

        //public override void OnBackPressed()
        //{

        //}

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            UserDialogs.Init(this);
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            // Inicializar el Scanner
            MobileBarcodeScanner.Initialize(this.Application);
            LoadApplication(new App());
        }
    }
}

