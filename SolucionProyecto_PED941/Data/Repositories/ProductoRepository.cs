using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SolucionProyecto_PED941.Models;
using System.Collections.Generic;

namespace SolucionProyecto_PED941.Data.Repositories
{
    public class ProductoRepository
    {
        private readonly ConexionDb _conexionDb = new ConexionDb();

        public void Insertar(Producto producto)
        {
            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = @"INSERT INTO Productos
                                (Codigo, Nombre, Precio, Stock, StockMinimo)
                                VALUES
                                (@Codigo, @Nombre, @Precio, @Stock, @StockMinimo)";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);

            cmd.ExecuteNonQuery();
        }

        public List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();

            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = "SELECT Id, Codigo, Nombre, Precio, Stock, StockMinimo FROM Productos ORDER BY Id DESC";

            using var cmd = new MySqlCommand(sql, conexion);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Producto
                {
                    Id = reader.GetInt32("Id"),
                    Codigo = reader.GetString("Codigo"),
                    Nombre = reader.GetString("Nombre"),
                    Precio = reader.GetDecimal("Precio"),
                    Stock = reader.GetInt32("Stock"),
                    StockMinimo = reader.GetInt32("StockMinimo")
                });
            }

            return lista;
        }
    }
}
