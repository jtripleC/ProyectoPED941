using SolucionProyecto_PED941.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Structures
{
    public class HashProducto
    {
        private class Nodo
        {
            public string Codigo { get; set; } = string.Empty;
            public Producto Producto { get; set; } = null!;
            public Nodo? Siguiente { get; set; }
        }

        private readonly Nodo?[] _tabla;
        private readonly int _tamano;

        public HashProducto(int tamano = 101)
        {
            _tamano = tamano;
            _tabla = new Nodo?[tamano];
        }

        private int FuncionHash(string codigo)
        {
            int suma = 0;

            foreach (char c in codigo.ToUpper())
            {
                suma += c;
            }

            return suma % _tamano;
        }

        public void Insertar(string codigo, Producto producto)
        {
            int indice = FuncionHash(codigo);

            Nodo? actual = _tabla[indice];

            while (actual != null)
            {
                if (actual.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Producto = producto;
                    return;
                }

                actual = actual.Siguiente;
            }

            Nodo nuevo = new Nodo
            {
                Codigo = codigo,
                Producto = producto,
                Siguiente = _tabla[indice]
            };

            _tabla[indice] = nuevo;
        }

        public Producto? Buscar(string codigo)
        {
            int indice = FuncionHash(codigo);

            Nodo? actual = _tabla[indice];

            while (actual != null)
            {
                if (actual.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    return actual.Producto;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public void Limpiar()
        {
            for (int i = 0; i < _tabla.Length; i++)
            {
                _tabla[i] = null;
            }
        }
    }
}