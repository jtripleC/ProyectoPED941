using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucionProyecto_PED941.Utils;
using SolucionProyecto_PED941.Structures;
using SolucionProyecto_PED941.Services;


namespace SolucionProyecto_PED941.Forms
{
    public partial class FormProductos : Form
    {
        private readonly ProductoRepository _productoRepository = new ProductoRepository();
        private readonly PilaOperaciones _pila = new PilaOperaciones();
        private readonly DeshacerService _deshacerService;
        private readonly HashProducto _hashProducto = new HashProducto();

        public FormProductos()
        {
            InitializeComponent();
            _deshacerService = new DeshacerService(_pila);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.ColumnHeadersHeight = 35;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dgvProductos.EnableHeadersVisualStyles = false;

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvProductos.RowTemplate.Height = 28;
        }

        private void CargarProductos()
        {
            var lista = _productoRepository.ObtenerTodos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;

            _hashProducto.Limpiar();

            foreach (var producto in lista)
            {
                _hashProducto.Insertar(producto.Codigo, producto);
            }

            if (dgvProductos.Columns["Id"] != null)
                dgvProductos.Columns["Id"].Visible = false;
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
                var ultimo = lista.First();

                _pila.Push(new OperacionDeshacer
                {
                    ProductoId = ultimo.Id,
                    Cantidad = ultimo.Stock,
                    Tipo = "CREAR"
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

        //Aquí es donde aplico la funcionalidad del boton deshacer.
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            var operacion = _deshacerService.Deshacer();

            if (operacion == null)
            {
                MessageBox.Show("No hay operaciones recientes");
                return;
            }

            if (operacion.Tipo == "CREAR")
            {
                _productoRepository.Eliminar(operacion.ProductoId);
            }

            CargarProductos();
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
    }
}


