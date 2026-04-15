using System.Collections.Generic;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Services
{
    internal class AlertaService
    {
        private ProductoRepository _repo = new ProductoRepository();

        public List<Producto> ObtenerAlertas()
        {
            return _repo.ObtenerStockBajo();
        }
    }
}