using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Structures
{
    internal class PilaOperaciones
    {
        private Stack<OperacionDeshacer> pila = new Stack<OperacionDeshacer>();

        public void Push(OperacionDeshacer operacion)
        {
            pila.Push(operacion);
        }

        public OperacionDeshacer Pop()
        {
            if (pila.Count == 0)
                return null;

            return pila.Pop();
        }

        public bool EstaVacia()
        {
            return pila.Count == 0;
        }
    }
}