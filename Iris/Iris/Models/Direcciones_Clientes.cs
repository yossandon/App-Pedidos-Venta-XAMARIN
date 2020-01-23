namespace Pedidos.Models
{
    public class Direcciones_Clientes
    {
        public int ID { get; set; }
        public int Id_Cliente { get; set; }
        public string Apodo { get; set; }
        public string Direccion { get; set; }
        public int Id_Ciudad { get; set; }
        public string Ciudad { get; set; }
        public int Id_Comuna { get; set; }
        public string Comuna { get; set; }
        public string Referencia { get; set; }
        public string Telefono_Celular { get; set; }
        public int Estado { get; set; }
        public string Email { get; set; }
    }
}
