using System.Threading.Tasks;

namespace Pedidos.Services
{
   public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
