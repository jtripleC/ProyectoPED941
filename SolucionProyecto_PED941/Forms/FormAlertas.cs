using SolucionProyecto_PED941.Services;

namespace SolucionProyecto_PED941.Forms
{
    public partial class FormAlertas : Form
    {
        private AlertaService alertaService = new AlertaService();

        public FormAlertas()
        {
            InitializeComponent();
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            CargarAlertas();
        }

        private void CargarAlertas()
        {
            dataGridView1.DataSource = alertaService.ObtenerAlertas();
        }
    }
}