using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionProyecto_PED941.Structures;

namespace SolucionProyecto_PED941.Services
{
    public static class PilasSession
    {
        
        public static PilaOperaciones PilaProductos { get; } = new PilaOperaciones();
        public static PilaOperaciones PilaEntradas { get; } = new PilaOperaciones();
        public static PilaOperaciones PilaSalidas { get; } = new PilaOperaciones();
    }
}
