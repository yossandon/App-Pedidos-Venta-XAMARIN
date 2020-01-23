namespace Pedidos.ViewModels
{
    using System.Data.SqlClient;
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=192.168.1.62, 1433;initial catalog=RestoBar;user id=sa;password=25071614";

            return cn;
        }
    }
}
