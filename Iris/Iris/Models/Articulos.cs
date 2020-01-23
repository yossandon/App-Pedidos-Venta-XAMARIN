namespace Pedidos.Models
{
    public class Articulos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public byte[] Imagen { get; set; }
        public string Codigo { get; set; }
        public int Precio_Venta { get; set; }
        public int Stock { get; set; }
        public double Evaluacion { get; set; }
        public int Costo_Envio { get; set; }
        public int Consumo_Minimo { get; set; }
        public string Tiempo_Espera { get; set; }
        public string Componentes { get; set; }
        public string Oferta { get; set; }
    }
}
