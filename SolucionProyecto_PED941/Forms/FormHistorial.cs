using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SolucionProyecto_PED941.Services;

namespace SolucionProyecto_PED941.Forms
{
    public partial class FormHistorial : Form
    {
        private readonly InventarioService _inventarioService = new InventarioService();

        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            var movimientos = _inventarioService.ObtenerHistorialCompleto();

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = movimientos;

            if (dgvHistorial.Columns["Id"] != null)
                dgvHistorial.Columns["Id"].Visible = false;
            if (dgvHistorial.Columns["ProductoId"] != null)
                dgvHistorial.Columns["ProductoId"].Visible = false;

            if (dgvHistorial.Columns["CodigoProducto"] != null)
                dgvHistorial.Columns["CodigoProducto"].HeaderText = "Código";
            if (dgvHistorial.Columns["NombreProducto"] != null)
                dgvHistorial.Columns["NombreProducto"].HeaderText = "Producto";
            if (dgvHistorial.Columns["TipoMovimiento"] != null)
                dgvHistorial.Columns["TipoMovimiento"].HeaderText = "Tipo";
            if (dgvHistorial.Columns["Cantidad"] != null)
                dgvHistorial.Columns["Cantidad"].HeaderText = "Cantidad";
            if (dgvHistorial.Columns["StockAnterior"] != null)
                dgvHistorial.Columns["StockAnterior"].HeaderText = "Stock Anterior";
            if (dgvHistorial.Columns["StockResultante"] != null)
                dgvHistorial.Columns["StockResultante"].HeaderText = "Stock Nuevo";
            if (dgvHistorial.Columns["Fecha"] != null)
                dgvHistorial.Columns["Fecha"].HeaderText = "Fecha";

            // Colorear filas por tipo de movimiento
            BeginInvoke(new Action(ColorearFilas));
        }

        private void ColorearFilas()
        {
            foreach (DataGridViewRow row in dgvHistorial.Rows)
            {
                if (row.Cells["TipoMovimiento"].Value == null)
                    continue;

                string tipo = row.Cells["TipoMovimiento"]
                    .Value
                    .ToString()
                    .Trim()
                    .ToUpper();

                if (tipo == "ENTRADA")
                {
                    row.Cells["TipoMovimiento"].Style.BackColor = Color.FromArgb(220, 255, 220);
                    row.Cells["TipoMovimiento"].Style.ForeColor = Color.FromArgb(0, 130, 0);
                    row.Cells["TipoMovimiento"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    row.Cells["TipoMovimiento"].Style.SelectionBackColor = Color.FromArgb(220, 255, 220);
                    row.Cells["TipoMovimiento"].Style.SelectionForeColor = Color.FromArgb(0, 130, 0);
                }
                else if (tipo == "SALIDA")
                {
                    row.Cells["TipoMovimiento"].Style.BackColor = Color.FromArgb(255, 220, 220);
                    row.Cells["TipoMovimiento"].Style.ForeColor = Color.FromArgb(180, 0, 0);
                    row.Cells["TipoMovimiento"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    row.Cells["TipoMovimiento"].Style.SelectionBackColor = Color.FromArgb(255, 220, 220);
                    row.Cells["TipoMovimiento"].Style.SelectionForeColor = Color.FromArgb(180, 0, 0);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }
    }
}
