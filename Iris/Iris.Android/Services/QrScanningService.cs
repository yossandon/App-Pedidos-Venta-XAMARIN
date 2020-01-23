using Pedidos.Services;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(Pedidos.Droid.Services.QrScanningService))]
namespace Pedidos.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        
        public async Task<string> ScanAsync()
        {
            try
            {
                var optionsDefault = new MobileBarcodeScanningOptions();
                var optionsCustom = new MobileBarcodeScanningOptions();

                var scanner = new MobileBarcodeScanner()
                {
                    TopText = "Acerque la cámara al código",
                    BottomText = "Toca la pantalla para enfocar",
                };
                var scanResult = await scanner.Scan(optionsCustom);
                return scanResult.Text;
            }
            catch (System.Exception)
            {
                throw;
            }
           
        }
    }
}