using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Structures
{
    public class ListaMovimientos
    {
        private class Nodo
        {
            public Movimiento Dato { get; set; } = null!;
            public Nodo? Siguiente { get; set; }
        }

        private Nodo? _cabeza;
        private int _count;

        public int Count => _count;

        public void AgregarAlInicio(Movimiento movimiento)
        {
            var nuevo = new Nodo { Dato = movimiento, Siguiente = _cabeza };
            _cabeza = nuevo;
            _count++;
        }

        public List<Movimiento> ObtenerTodos()
        {
            var lista = new List<Movimiento>();
            var actual = _cabeza;
            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return lista;
        }

        public void Limpiar()
        {
            _cabeza = null;
            _count = 0;
        }
    }
}
