using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Models
{
    public class Comandas
    {
        public int Id_Mesa { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public int Descuento { get; set; }
        public string Codigo { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Detalle_Venta { get; set; }
        public string Observacion { get; set; }
    }
}
