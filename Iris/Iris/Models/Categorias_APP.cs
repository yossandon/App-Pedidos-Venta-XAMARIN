namespace Pedidos.Models
{
    public class Categorias_APP
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public int Orden { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
    }
}
