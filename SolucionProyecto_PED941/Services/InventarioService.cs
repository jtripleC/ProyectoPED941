using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Structures;

namespace SolucionProyecto_PED941.Services
{
    public class InventarioService
    {
        private readonly MovimientoRepository _movimientoRepository = new();
        private readonly ListaMovimientos _lista = new();

        public List<Movimiento> ObtenerHistorialCompleto()
        {
            _lista.Limpiar();

            var movimientos = _movimientoRepository.ObtenerTodos();

            
            foreach (var m in movimientos)
                _lista.AgregarAlInicio(m);

           
            var resultado = _lista.ObtenerTodos();
            resultado.Reverse();
            return resultado;
        }
    }
}
