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
    public partial class FormMain : Form
    {
        private Guna.UI2.WinForms.Guna2Button? _btnActivo = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form form, Guna.UI2.WinForms.Guna2Button btnClickeado)
        {
            // Resaltar botón activo
            if (_btnActivo != null)
            {
                _btnActivo.FillColor = Color.FromArgb(40, 40, 58);
                _btnActivo.ForeColor = Color.FromArgb(200, 200, 220);
            }

            btnClickeado.FillColor = Color.FromArgb(100, 88, 255);
            btnClickeado.ForeColor = Color.White;
            _btnActivo = btnClickeado;

            // Cargar form
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormProductos(), btnProductos);

        private void btnEntradas_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormEntradas(), btnEntradas);

        private void btnSalidas_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormSalidas(), btnSalidas);

        private void btnInventario_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormInventario(), btnInventario);

        private void btnHistorial_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormHistorial(), btnHistorial);

        private void btnAlertas_Click(object sender, EventArgs e) =>
            AbrirFormulario(new FormAlertas(), btnAlertas);
    }
}