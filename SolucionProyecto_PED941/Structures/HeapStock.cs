using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Structures
{
    public class HeapStock
    {
        private readonly List<AlertaStock> _heap = new();

        public int Count => _heap.Count;

        public void Insertar(AlertaStock alerta)
        {
            _heap.Add(alerta);
            SubirUltimo(_heap.Count - 1);
        }

        public AlertaStock? Extraer()
        {
            if (_heap.Count == 0) return null;

            var raiz = _heap[0];
            int ultimo = _heap.Count - 1;
            _heap[0] = _heap[ultimo];
            _heap.RemoveAt(ultimo);

            if (_heap.Count > 0)
                BajarPrimero(0);

            return raiz;
        }

        public List<AlertaStock> ObtenerTodas()
        {
            
            var copia = new HeapStock();
            foreach (var a in _heap)
                copia.Insertar(a);

            var resultado = new List<AlertaStock>();
            AlertaStock? item;
            while ((item = copia.Extraer()) != null)
                resultado.Add(item);

            return resultado;
        }

        public void Limpiar() => _heap.Clear();

        
        private void SubirUltimo(int i)
        {
            while (i > 0)
            {
                int padre = (i - 1) / 2;
                if (_heap[padre].Prioridad <= _heap[i].Prioridad) break;
                (_heap[padre], _heap[i]) = (_heap[i], _heap[padre]);
                i = padre;
            }
        }

        
        private void BajarPrimero(int i)
        {
            int n = _heap.Count;
            while (true)
            {
                int menor = i;
                int izq = 2 * i + 1;
                int der = 2 * i + 2;

                if (izq < n && _heap[izq].Prioridad < _heap[menor].Prioridad)
                    menor = izq;
                if (der < n && _heap[der].Prioridad < _heap[menor].Prioridad)
                    menor = der;

                if (menor == i) break;
                (_heap[menor], _heap[i]) = (_heap[i], _heap[menor]);
                i = menor;
            }
        }
    }
}
