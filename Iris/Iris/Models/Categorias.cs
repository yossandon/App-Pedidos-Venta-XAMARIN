using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Models
{
    public class Categorias
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Correlativo { get; set; }
    }
}
