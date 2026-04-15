using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionProyecto_PED941.Data
{
    public static class DbConfig
    {
        public static string ConnectionString =>
            "Server=localhost;Port=3306;User ID=root;Password=root;Database=solucionproyecto_ped941;";
    }
}
