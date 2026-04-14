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
        public FormMain()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            form.Show();


        }
        /*
         * Apertura de los otros formularios al hacer click en los botones correspondientes, utilizando el método AbrirFormulario para mostrar cada formulario dentro del panelContenedor.
         * 
         * */
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProductos());
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEntradas());
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSalidas());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormInventario());
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAlertas());
        }
    }
}
