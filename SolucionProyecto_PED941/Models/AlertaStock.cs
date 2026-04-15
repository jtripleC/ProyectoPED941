using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Models
{
    public class AlertaStock
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int Prioridad { get; set; }
    }
}
