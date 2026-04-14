using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Utils
{
    public static class Validaciones
    {
        public static bool EsTextoVacio(string? valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }

        public static bool EsDecimalValido(string? valor)
        {
            return decimal.TryParse(valor, out _);
        }

        public static bool EsEnteroValido(string? valor)
        {
            return int.TryParse(valor, out _);
        }

        public static bool EsEnteroNoNegativo(string? valor)
        {
            return int.TryParse(valor, out int numero) && numero >= 0;
        }

        public static bool EsDecimalNoNegativo(string? valor)
        {
            return decimal.TryParse(valor, out decimal numero) && numero >= 0;
        }
    }
}
