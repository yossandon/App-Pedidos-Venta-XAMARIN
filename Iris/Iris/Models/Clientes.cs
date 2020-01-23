namespace Pedidos.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Ciudad { get; set; }
        public int Comuna { get; set; }
        public string Telefono_Celular { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
    }
}
