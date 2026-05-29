using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Models
{
    public class OperacionDeshacer
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public int StockAnterior { get; set; }

        // Campos para deshacer edición
        public string CodigoAnterior { get; set; } = string.Empty;
        public string NombreAnterior { get; set; } = string.Empty;
        public decimal PrecioAnterior { get; set; }
        public int StockMinimoAnterior { get; set; }
    }


}