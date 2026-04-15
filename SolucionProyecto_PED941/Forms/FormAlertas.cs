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
            dgvAlertas.DataSource = null;
            dgvAlertas.DataSource = alertaService.ObtenerAlertasPriorizadas();
            dgvAlertas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlertas.ColumnHeadersHeight = 35;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dgvAlertas.EnableHeadersVisualStyles = false;

            dgvAlertas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvAlertas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAlertas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAlertas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvAlertas.RowTemplate.Height = 28;
        }
     }
}