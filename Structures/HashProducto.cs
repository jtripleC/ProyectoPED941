using System.Collections.Generic;

namespace SolucionProyecto_PED941.Structures
{
    public class HashProducto
    {
        private Dictionary<string, Producto> tabla = new Dictionary<string, Producto>();

        public void Insertar(Producto producto)
        {
            tabla[producto.Codigo] = producto;
        }

        public Producto Buscar(string codigo)
        {
            return tabla.ContainsKey(codigo) ? tabla[codigo] : null;
        }

        public bool Existe(string codigo)
        {
            return tabla.ContainsKey(codigo);
        }

        public void Eliminar(string codigo)
        {
            if (tabla.ContainsKey(codigo))
                tabla.Remove(codigo);
        }
    }
}
