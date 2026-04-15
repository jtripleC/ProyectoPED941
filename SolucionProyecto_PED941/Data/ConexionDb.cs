using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SolucionProyecto_PED941.Data
{
    public class ConexionDb
    {
        public MySqlConnection CrearConexion()
        {
            return new MySqlConnection(DbConfig.ConnectionString);
        }
    }
}
