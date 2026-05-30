using System.Collections.Generic;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Structures;

namespace SolucionProyecto_PED941.Services
{
    public class AlertaService
    {
        private readonly ProductoRepository _productoRepository = new();
        private readonly HeapStock _heap = new(); 

        public List<AlertaStock> ObtenerAlertasPriorizadas()
        {
            _heap.Limpiar();

            var productos = _productoRepository.ObtenerStockBajo();

            foreach (var producto in productos)
            {
                int prioridad = producto.Stock == 0 ? 1
                              : producto.Stock < producto.StockMinimo ? 2
                              : 3;

                _heap.Insertar(new AlertaStock
                {
                    Codigo = producto.Codigo,
                    Nombre = producto.Nombre,
                    Stock = producto.Stock,
                    StockMinimo = producto.StockMinimo,
                    Prioridad = prioridad
                });
            }

            return _heap.ObtenerTodas();
        }
    }
}