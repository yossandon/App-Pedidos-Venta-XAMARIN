namespace Pedidos.Models
{
    public class Detalle_Comanda
    {
        public int ID { get; set; }
        public int Id_Comanda { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public string Observación { get; set; }
        public byte[] Imagen { get; set; }
        public string Codigo { get; set; }
        public int Precio_Venta { get; set; }
        public int Costo_Envio { get; set; }
        public int Consumo_Minimo { get; set; }
        public double Evaluacion { get; set; }
        public string Componentes { get; set; }
        public string Tiempo_Espera { get; set; }
    }
}
