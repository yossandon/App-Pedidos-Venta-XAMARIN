
namespace Pedidos.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Propiedades
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Contructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
