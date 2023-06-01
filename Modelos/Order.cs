using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public decimal Total { get; set; }

    }
}
