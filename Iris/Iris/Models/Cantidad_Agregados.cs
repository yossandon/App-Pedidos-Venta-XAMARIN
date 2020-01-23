namespace Pedidos.Models
{
    public class Cantidad_Agregados
    {
        public int ID { get; set; }
        public int Id_Articulo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Mensaje { get; set; }
        public int N_Solicitud { get; set; }
    }
}
