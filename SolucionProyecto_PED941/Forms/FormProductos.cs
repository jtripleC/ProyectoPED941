using MySql.Data.MySqlClient;
using SolucionProyecto_PED941.Data;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Services;
using SolucionProyecto_PED941.Structures;
using SolucionProyecto_PED941.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SolucionProyecto_PED941.Forms
{
    public partial class FormProductos : Form
    {
        private readonly ProductoRepository _productoRepository = new ProductoRepository();
        private readonly PilaOperaciones _pila = PilasSession.PilaProductos;
        private readonly DeshacerService _deshacerService;
        private readonly HashProducto _hashProducto = new HashProducto();
        private int _productoIdSeleccionado = -1;

        public FormProductos()
        {
            InitializeComponent();
            _deshacerService = new DeshacerService(_pila);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.CellClick += dgvProductos_CellClick;
            CargarProductos();
        }

        private void CargarProductos()
        {
            var lista = _productoRepository.ObtenerTodos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;

            _hashProducto.Limpiar();
            foreach (var producto in lista)
                _hashProducto.Insertar(producto.Codigo, producto);

            if (dgvProductos.Columns["Id"] != null)
                dgvProductos.Columns["Id"].Visible = false;
        }
        // Esto sirve para manejar el evento de clic en una celda del DataGridView para cargar los datos del producto seleccionado en los campos de texto
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProductos.Rows[e.RowIndex];
            _productoIdSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

            string codigo = row.Cells["Codigo"].Value?.ToString() ?? "";
            string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";
            string precio = row.Cells["Precio"].Value?.ToString() ?? "";
            string stock = row.Cells["Stock"].Value?.ToString() ?? "";
            string stockMin = row.Cells["StockMinimo"].Value?.ToString() ?? "";

            
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();


            BeginInvoke(new Action(() =>
            {
                txtCodigo.Text = codigo;
                txtNombre.Text = nombre;
                txtPrecio.Text = precio;
                txtStock.Text = stock;
                txtStockMinimo.Text = stockMin;

                txtCodigo.Focus();
                txtCodigo.SelectionStart = txtCodigo.Text.Length;

                
                txtNombre.SelectionStart = txtNombre.Text.Length;
                txtPrecio.SelectionStart = txtPrecio.Text.Length;
                txtStock.SelectionStart = txtStock.Text.Length;
                txtStockMinimo.SelectionStart = txtStockMinimo.Text.Length;
            }));

            btnGuardar.Visible = false;
            btnLimpiar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                var producto = new Producto
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = decimal.Parse(txtPrecio.Text.Trim()),
                    Stock = int.Parse(txtStock.Text.Trim()),
                    StockMinimo = int.Parse(txtStockMinimo.Text.Trim())
                };

                _productoRepository.Insertar(producto);

                var lista = _productoRepository.ObtenerTodos();
                var ultimo = lista.OrderByDescending(p => p.Id).First();

                _pila.Push(new OperacionDeshacer
                {
                    ProductoId = ultimo.Id,
                    Cantidad = ultimo.Stock,
                    Tipo = "CREAR",
                    CodigoAnterior = ultimo.Codigo,
                    NombreAnterior = ultimo.Nombre
                });

                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            var operacion = _deshacerService.Deshacer();

            if (operacion == null)
            {
                MessageBox.Show("No hay operaciones recientes para deshacer.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (operacion.Tipo)
            {
                case "CREAR":
                    _productoRepository.Eliminar(operacion.ProductoId);
                    MessageBox.Show(
                        $"Operación deshecha: Creación\nProducto eliminado: {operacion.CodigoAnterior} - {operacion.NombreAnterior}",
                        "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "EDITAR":
                    var productoRestaurado = new Producto
                    {
                        Id = operacion.ProductoId,
                        Codigo = operacion.CodigoAnterior,
                        Nombre = operacion.NombreAnterior,
                        Precio = operacion.PrecioAnterior,
                        Stock = operacion.StockAnterior,
                        StockMinimo = operacion.StockMinimoAnterior
                    };
                    _productoRepository.Actualizar(productoRestaurado);
                    MessageBox.Show(
                        $"Operación deshecha: Modificación\nProducto: {operacion.CodigoAnterior} - {operacion.NombreAnterior}\nStock restaurado: {operacion.StockAnterior}",
                        "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "ELIMINAR":
                    var productoEliminado = new Producto
                    {
                        Codigo = operacion.CodigoAnterior,
                        Nombre = operacion.NombreAnterior,
                        Precio = operacion.PrecioAnterior,
                        Stock = operacion.StockAnterior,
                        StockMinimo = operacion.StockMinimoAnterior
                    };
                    _productoRepository.Reinsertar(productoEliminado);
                    MessageBox.Show(
                        $"Operación deshecha: Eliminación\nProducto restaurado: {operacion.CodigoAnterior} - {operacion.NombreAnterior}\nStock: {operacion.StockAnterior}",
                        "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            RestablecerModoFormulario();
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado == -1) return;
            if (!ValidarCampos()) return;

            if (_productoRepository.ExisteCodigoONombre(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                _productoIdSeleccionado))
            {
                MessageBox.Show("Ya existe otro producto con ese código o nombre.",
                    "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show(
                "¿Está seguro que desea editar este producto?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                var producto = new Producto
                {
                    Id = _productoIdSeleccionado,
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = decimal.Parse(txtPrecio.Text.Trim()),
                    Stock = int.Parse(txtStock.Text.Trim()),
                    StockMinimo = int.Parse(txtStockMinimo.Text.Trim())
                };

                var productoActual = _productoRepository.ObtenerTodos()
                    .First(p => p.Id == _productoIdSeleccionado);

                _pila.Push(new OperacionDeshacer
                {
                    ProductoId = _productoIdSeleccionado,
                    Tipo = "EDITAR",
                    CodigoAnterior = productoActual.Codigo,
                    NombreAnterior = productoActual.Nombre,
                    PrecioAnterior = productoActual.Precio,
                    StockAnterior = productoActual.Stock,
                    StockMinimoAnterior = productoActual.StockMinimo
                });

                _productoRepository.Actualizar(producto);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RestablecerModoFormulario();
                CargarProductos();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Ya existe un producto con ese código. Ingrese un código diferente.",
                    "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private readonly MovimientoRepository _movimientoRepository = new MovimientoRepository();



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado == -1) return;

            var resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar este producto?\nSe eliminarán también todos sus movimientos.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            var productoActual = _productoRepository.ObtenerTodos()
            .First(p => p.Id == _productoIdSeleccionado);

            _pila.Push(new OperacionDeshacer
            {
                ProductoId = _productoIdSeleccionado,
                Tipo = "ELIMINAR",
                CodigoAnterior = productoActual.Codigo,
                NombreAnterior = productoActual.Nombre,
                PrecioAnterior = productoActual.Precio,
                StockAnterior = productoActual.Stock,
                StockMinimoAnterior = productoActual.StockMinimo
            });

            _movimientoRepository.EliminarPorProducto(_productoIdSeleccionado);
            _productoRepository.Eliminar(_productoIdSeleccionado);

            MessageBox.Show("Producto eliminado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            RestablecerModoFormulario();
            CargarProductos();
        }

        private void RestablecerModoFormulario()
        {
            _productoIdSeleccionado = -1;
            LimpiarCampos();
            btnGuardar.Visible = true;
            btnLimpiar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
            txtCodigo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RestablecerModoFormulario();
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (Validaciones.EsTextoVacio(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código del producto.");
                txtCodigo.Focus();
                return false;
            }
            if (Validaciones.EsTextoVacio(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                txtNombre.Focus();
                return false;
            }
            if (!Validaciones.EsDecimalNoNegativo(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio válido.");
                txtPrecio.Focus();
                return false;
            }
            if (!Validaciones.EsEnteroNoNegativo(txtStock.Text))
            {
                MessageBox.Show("Ingrese un stock válido.");
                txtStock.Focus();
                return false;
            }
            if (!Validaciones.EsEnteroNoNegativo(txtStockMinimo.Text))
            {
                MessageBox.Show("Ingrese un stock mínimo válido.");
                txtStockMinimo.Focus();
                return false;
            }
            return true;
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscarCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarCodigo.Focus();
                return;
            }

            Producto? producto = _hashProducto.Buscar(codigo);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = new List<Producto> { producto };

            if (dgvProductos.Columns["Id"] != null)
                dgvProductos.Columns["Id"].Visible = false;
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}