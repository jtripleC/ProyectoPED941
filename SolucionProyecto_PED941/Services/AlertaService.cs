using System.Collections.Generic;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Structures;

namespace SolucionProyecto_PED941.Services
{
    public class AlertaService
    {
        private readonly ProductoRepository _productoRepository = new();
        private readonly ColaPrioridadStock _cola = new();

        public List<AlertaStock> ObtenerAlertasPriorizadas()
        {
            _cola.Limpiar();

            var productos = _productoRepository.ObtenerStockBajo();

            foreach (var producto in productos)
            {
                int prioridad;

                if (producto.Stock == 0)
                    prioridad = 1;
                else if (producto.Stock < producto.StockMinimo)
                    prioridad = 2;
                else
                    prioridad = 3;

                _cola.Insertar(new AlertaStock
                {
                    Codigo = producto.Codigo,
                    Nombre = producto.Nombre,
                    Stock = producto.Stock,
                    StockMinimo = producto.StockMinimo,
                    Prioridad = prioridad
                });
            }

            return _cola.ObtenerTodas();
        }
    }
}