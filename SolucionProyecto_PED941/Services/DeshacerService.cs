using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Structures;

namespace SolucionProyecto_PED941.Services
{
    internal class DeshacerService
    {
        private readonly PilaOperaciones _pila;

        public DeshacerService(PilaOperaciones pila)
        {
            _pila = pila;
        }

        //Este nos va a servir para deshacer la última operación realizada en el FormProductos
        public OperacionDeshacer Deshacer()
        {
            return _pila.Pop();
        }

        //Y este lo dejo listo desde ya para los formularios de Entradas y Salidas, este revierte pero el stock de un producto
        //existente sin eliminar el producto en si, sino mas bien eliminando la cantidad de la última operación realizada, ya sea una entrada o una salida

        public int Deshacer(Producto producto)
        {
            var operacion = _pila.Pop();

            if (operacion == null)
                return producto.Stock;

            producto.Stock -= operacion.Cantidad;

            return producto.Stock;
        }
    }
}