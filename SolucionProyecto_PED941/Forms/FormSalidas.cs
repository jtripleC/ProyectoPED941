using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;
using SolucionProyecto_PED941.Structures;
using SolucionProyecto_PED941.Services;

namespace SolucionProyecto_PED941.Forms
{
    public partial class FormSalidas : Form
    {
        private readonly ProductoRepository _productoRepository = new ProductoRepository();
        private readonly MovimientoRepository _movimientoRepository = new MovimientoRepository();
        private readonly PilaOperaciones _pila = PilasSession.PilaSalidas;
        private readonly DeshacerService _deshacerService;
        private readonly HashProducto _hashProducto = new HashProducto();

        public FormSalidas()
        {
            InitializeComponent();
            _deshacerService = new DeshacerService(_pila);
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            CargarProductosEnCombo();
            CargarMovimientos();
        }

        private void CargarProductosEnCombo()
        {
            var productos = _productoRepository.ObtenerTodos();

            _hashProducto.Limpiar();
            foreach (var p in productos)
                _hashProducto.Insertar(p.Codigo, p);

            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
        }

        private void CargarMovimientos()
        {
            var movimientos = _movimientoRepository.ObtenerTodos()
                .Where(m => m.TipoMovimiento == "SALIDA")
                .ToList();

            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = movimientos;

            if (dgvMovimientos.Columns["Id"] != null)
                dgvMovimientos.Columns["Id"].Visible = false;
            if (dgvMovimientos.Columns["ProductoId"] != null)
                dgvMovimientos.Columns["ProductoId"].Visible = false;
            if (dgvMovimientos.Columns["TipoMovimiento"] != null)
                dgvMovimientos.Columns["TipoMovimiento"].Visible = false;

            if (dgvMovimientos.Columns["CodigoProducto"] != null)
                dgvMovimientos.Columns["CodigoProducto"].HeaderText = "Código";
            if (dgvMovimientos.Columns["NombreProducto"] != null)
                dgvMovimientos.Columns["NombreProducto"].HeaderText = "Producto";
            if (dgvMovimientos.Columns["Cantidad"] != null)
                dgvMovimientos.Columns["Cantidad"].HeaderText = "Cantidad";
            if (dgvMovimientos.Columns["StockAnterior"] != null)
                dgvMovimientos.Columns["StockAnterior"].HeaderText = "Stock Anterior";
            if (dgvMovimientos.Columns["StockResultante"] != null)
                dgvMovimientos.Columns["StockResultante"].HeaderText = "Stock Nuevo";
            if (dgvMovimientos.Columns["Fecha"] != null)
                dgvMovimientos.Columns["Fecha"].HeaderText = "Fecha";
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedItem is not Producto productoSeleccionado)
                {
                    MessageBox.Show("Seleccione un producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida (mayor a 0).", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                // Validación clave: no puedes sacar más de lo que hay
                if (cantidad > productoSeleccionado.Stock)
                {
                    MessageBox.Show($"Stock insuficiente. Stock actual: {productoSeleccionado.Stock} unidades.",
                        "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                int stockAnterior = productoSeleccionado.Stock;
                int stockNuevo = stockAnterior - cantidad;

                _productoRepository.ActualizarStock(productoSeleccionado.Id, stockNuevo);

                var movimiento = new Movimiento
                {
                    ProductoId = productoSeleccionado.Id,
                    TipoMovimiento = "SALIDA",
                    Cantidad = cantidad,
                    StockAnterior = stockAnterior,
                    StockResultante = stockNuevo,
                    Fecha = DateTime.Now
                };

                _movimientoRepository.Insertar(movimiento);

                _pila.Push(new OperacionDeshacer
                {
                    ProductoId = productoSeleccionado.Id,
                    Cantidad = cantidad,
                    StockAnterior = stockAnterior,
                    Tipo = "SALIDA"
                });

                MessageBox.Show($"Salida registrada correctamente.\nStock actualizado: {stockNuevo} unidades.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCantidad.Clear();
                CargarProductosEnCombo();
                CargarMovimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida:\n" + ex.Message,
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

            _productoRepository.ActualizarStock(operacion.ProductoId, operacion.StockAnterior);

            var ultimoMovimiento = _movimientoRepository.ObtenerUltimoPorProducto(operacion.ProductoId);
            if (ultimoMovimiento != null)
                _movimientoRepository.Eliminar(ultimoMovimiento.Id);

            MessageBox.Show("Última salida deshecha correctamente.", "Deshacer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarProductosEnCombo();
            CargarMovimientos();
        }
    }
}
