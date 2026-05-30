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
            dgvAlertas.ColumnHeadersHeight = 36;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAlertas.EnableHeadersVisualStyles = false;
            dgvAlertas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAlertas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAlertas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAlertas.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F);
            dgvAlertas.RowTemplate.Height = 30;
            dgvAlertas.RowPrePaint += (s, e) =>
            {
                e.PaintParts &= ~DataGridViewPaintParts.SelectionBackground;
            };
            dgvAlertas.CellFormatting += dgvAlertas_CellFormatting;
        }

        private void dgvAlertas_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e)
        {
            
            string columnName = dgvAlertas.Columns[e.ColumnIndex].Name;


            if (dgvAlertas.Columns[e.ColumnIndex].Name == "Prioridad")
            {
                string prioridad = e.Value?.ToString()?.ToUpper() ?? "";

                DataGridViewCell cell = dgvAlertas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Font =new Font("Segoe UI", 8.5F, FontStyle.Bold);

                switch (prioridad)
                {
                    case "1":

                        cell.Style.BackColor = Color.FromArgb(220, 53, 69);
                        cell.Style.ForeColor = Color.White;
                        break;

                    case "2":

                        cell.Style.BackColor = Color.FromArgb(255, 193, 7);
                        cell.Style.ForeColor = Color.Black;
                        break;

                    case "3":

                        cell.Style.BackColor = Color.FromArgb(40, 167, 69);
                        cell.Style.ForeColor = Color.White;
                        break;
                }
            }
        }
    }
}