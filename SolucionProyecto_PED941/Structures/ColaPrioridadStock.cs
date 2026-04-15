using SolucionProyecto_PED941.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Structures
{
    public class ColaPrioridadStock
    {
        private readonly List<AlertaStock> _alertas = new();

        public void Insertar(AlertaStock alerta)
        {
            _alertas.Add(alerta);
            _alertas.Sort((a, b) => a.Prioridad.CompareTo(b.Prioridad));
        }

        public AlertaStock? Extraer()
        {
            if (_alertas.Count == 0)
                return null;

            var alerta = _alertas[0];
            _alertas.RemoveAt(0);
            return alerta;
        }

        public List<AlertaStock> ObtenerTodas()
        {
            return _alertas.OrderBy(a => a.Prioridad).ToList();
        }

        public void Limpiar()
        {
            _alertas.Clear();
        }
    }
}
