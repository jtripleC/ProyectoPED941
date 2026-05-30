using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Data.Repositories
{
    public class MovimientoRepository
    {
        private readonly ConexionDb _conexionDb = new ConexionDb();

        public void Insertar(Movimiento movimiento)
        {
            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = @"INSERT INTO Movimientos 
                                (ProductoId, TipoMovimiento, Cantidad, StockAnterior, StockResultante, Fecha)
                                VALUES
                                (@ProductoId, @TipoMovimiento, @Cantidad, @StockAnterior, @StockResultante, @Fecha)";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@ProductoId", movimiento.ProductoId);
            cmd.Parameters.AddWithValue("@TipoMovimiento", movimiento.TipoMovimiento.ToUpper().Trim());
            cmd.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad);
            cmd.Parameters.AddWithValue("@StockAnterior", movimiento.StockAnterior);
            cmd.Parameters.AddWithValue("@StockResultante", movimiento.StockResultante);
            cmd.Parameters.AddWithValue("@Fecha", movimiento.Fecha);

            cmd.ExecuteNonQuery();
        }

        public List<Movimiento> ObtenerTodos()
        {
            var lista = new List<Movimiento>();

            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = @"SELECT m.Id, m.ProductoId, m.TipoMovimiento, m.Cantidad, 
                                        m.StockAnterior, m.StockResultante, m.Fecha,
                                        p.Codigo AS CodigoProducto, p.Nombre AS NombreProducto
                                 FROM Movimientos m
                                 INNER JOIN Productos p ON m.ProductoId = p.Id
                                 ORDER BY m.Fecha DESC";

            using var cmd = new MySqlCommand(sql, conexion);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Movimiento
                {
                    Id = reader.GetInt32("Id"),
                    ProductoId = reader.GetInt32("ProductoId"),
                    TipoMovimiento = reader.GetString("TipoMovimiento"),
                    Cantidad = reader.GetInt32("Cantidad"),
                    StockAnterior = reader.GetInt32("StockAnterior"),
                    StockResultante = reader.GetInt32("StockResultante"),
                    Fecha = reader.GetDateTime("Fecha"),
                    CodigoProducto = reader.GetString("CodigoProducto"),
                    NombreProducto = reader.GetString("NombreProducto")
                });
            }

            return lista;
        }

        public Movimiento? ObtenerUltimoPorProducto(int productoId)
        {
            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = @"SELECT m.Id, m.ProductoId, m.TipoMovimiento, m.Cantidad,
                                        m.StockAnterior, m.StockResultante, m.Fecha,
                                        p.Codigo AS CodigoProducto, p.Nombre AS NombreProducto
                                 FROM Movimientos m
                                 INNER JOIN Productos p ON m.ProductoId = p.Id
                                 WHERE m.ProductoId = @ProductoId
                                 ORDER BY m.Fecha DESC
                                 LIMIT 1";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@ProductoId", productoId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Movimiento
                {
                    Id = reader.GetInt32("Id"),
                    ProductoId = reader.GetInt32("ProductoId"),
                    TipoMovimiento = reader.GetString("TipoMovimiento"),
                    Cantidad = reader.GetInt32("Cantidad"),
                    StockAnterior = reader.GetInt32("StockAnterior"),
                    StockResultante = reader.GetInt32("StockResultante"),
                    Fecha = reader.GetDateTime("Fecha"),
                    CodigoProducto = reader.GetString("CodigoProducto"),
                    NombreProducto = reader.GetString("NombreProducto")
                };
            }

            return null;
        }
        //Esto sirve para borrar tambien el historial de movimientos de un producto que se elimine
        public void EliminarPorProducto(int productoId)
        {
            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = "DELETE FROM Movimientos WHERE ProductoId = @ProductoId";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@ProductoId", productoId);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int movimientoId)
        {
            using var conexion = _conexionDb.CrearConexion();
            conexion.Open();

            const string sql = "DELETE FROM Movimientos WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@Id", movimientoId);

            cmd.ExecuteNonQuery();
        }
    }
}
