using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string TipoMovimiento { get; set; } = string.Empty; 
        public int Cantidad { get; set; }
        public int StockAnterior { get; set; }
        public int StockResultante { get; set; }
        public DateTime Fecha { get; set; }

        

        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
    }
}
