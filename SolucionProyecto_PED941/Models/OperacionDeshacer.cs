using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Models
{
    internal class OperacionDeshacer
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}