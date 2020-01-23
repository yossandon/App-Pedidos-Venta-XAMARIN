using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Models
{
    public class Empleados
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
    }
}
