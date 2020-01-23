namespace Pedidos.Models
{
    public class Envio_App
    {
        public int ID { get; set; }
        public int Id_Comanda { get; set; }
        public int Tipo_Envio { get; set; }
        public int Forma_Pago { get; set; }
        public string Informacion_Adicional { get; set; }
        public int Estado { get; set; }
    }
}
