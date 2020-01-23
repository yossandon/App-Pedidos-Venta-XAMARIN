namespace Pedidos.Models
{
    public class Anexo_Empresa
    {
        public int ID { get; set; }
        public int Id_Empresa { get; set; }
        public int Costo_Envio { get; set; }
        public bool Pago_On_Line { get; set; }
        public bool Pago_Red_Compra { get; set; }
        public double Evaluacion { get; set; }
        public bool Acumula_Puntos_Clientes { get; set; }
        public bool Consumo_Minimo { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public int Hora_Apertura_Lunes_Viernes_HH { get; set; }
        public int Hora_Apertura_Lunes_Viernes_MM { get; set; }
        public int Hora_Cierre_Lunes_Viernes_HH { get; set; }
        public int Hora_Cierre_Lunes_Viernes_MM { get; set; }
        public int Hora_Apertura_Sabado_HH { get; set; }
        public int Hora_Apertura_Sabado_MM { get; set; }
        public int Hora_Cierre_Sabado_HH { get; set; }
        public int Hora_Cierre_Sabado_MM { get; set; }
        public int Hora_Apertura_Domingo_HH { get; set; }
        public int Hora_Apertura_Domingo_MM { get; set; }
        public int Hora_Cierre_Domingo_HH { get; set; }
        public int Hora_Cierre_Domingo_MM { get; set; }
        public int Estado { get; set; }
    }
}
