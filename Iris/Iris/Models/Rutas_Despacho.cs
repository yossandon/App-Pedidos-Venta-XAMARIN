namespace Pedidos.Models
{
    public class Rutas_Despacho
    {
        public int ID { get; set; }
        public int Id_Comanda { get; set; }
        public int Id_Venta { get; set; }
        public int N_Boleta { get; set; }
        public int Id_Empleado { get; set; }
        public string Fecha_Hora_Inicio { get; set; }
        public string Fecha_Hora_Termino { get; set; }
        public string Direccion_Original_Despacho { get; set; }
        public string Direccion_Alternativa_Despacho { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int Monto_a_Cancelar { get; set; }
        public int Vuelto { get; set; }
        public int Estado { get; set; }
    }
}
