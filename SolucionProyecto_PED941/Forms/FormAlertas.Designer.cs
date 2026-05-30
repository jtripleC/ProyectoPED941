namespace SolucionProyecto_PED941.Forms
{
    partial class FormAlertas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();
            dgvAlertas =new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize) dgvAlertas).BeginInit();
            SuspendLayout();

            // dgvAlertas

            dgvAlertas.AllowUserToAddRows = false;
            dgvAlertas.AllowUserToDeleteRows = false;
            dgvAlertas.AllowUserToResizeRows = false;
            dgvAlertas.ReadOnly = true;
            dgvAlertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlertas.MultiSelect = false;
            dgvStyle1.BackColor = Color.White;
            dgvAlertas.AlternatingRowsDefaultCellStyle =dgvStyle1;
            dgvStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStyle2.BackColor =Color.FromArgb(100, 88, 255);
            dgvStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvStyle2.ForeColor = Color.White;
            dgvStyle2.SelectionBackColor =  Color.FromArgb(100, 88, 255);
            dgvStyle2.SelectionForeColor = Color.White;
            dgvStyle2.WrapMode = DataGridViewTriState.True;
            dgvAlertas.ColumnHeadersDefaultCellStyle =dgvStyle2;
            dgvAlertas.ColumnHeadersHeight = 36;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStyle3.BackColor = Color.White;
            dgvStyle3.Font = new Font("Segoe UI", 8.5F);
            dgvStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.WrapMode = DataGridViewTriState.False;
            dgvAlertas.DefaultCellStyle = dgvStyle3;
            dgvAlertas.Dock = DockStyle.Fill;
            dgvAlertas.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.Location = new Point(0, 0);
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.RowHeadersVisible = false;
            dgvAlertas.RowHeadersWidth = 51;
            dgvAlertas.RowTemplate.Height = 30;
            dgvAlertas.Size = new Size(800, 397);
            dgvAlertas.TabIndex = 0;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.BackColor =  Color.White;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.White;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor =Color.FromArgb(71, 69, 94);
            dgvAlertas.ThemeStyle.BackColor =  Color.White;
            dgvAlertas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAlertas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlertas.ThemeStyle.HeaderStyle.Font =  new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAlertas.ThemeStyle.HeaderStyle.ForeColor =  Color.White;
            dgvAlertas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAlertas.ThemeStyle.HeaderStyle.Height = 36;
            dgvAlertas.ThemeStyle.ReadOnly = true;
            dgvAlertas.ThemeStyle.RowsStyle.BackColor =  Color.White;
            dgvAlertas.ThemeStyle.RowsStyle.BorderStyle =DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlertas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8.5F);
            dgvAlertas.ThemeStyle.RowsStyle.ForeColor =Color.FromArgb(71, 69, 94);
            dgvAlertas.ThemeStyle.RowsStyle.Height = 30;
            dgvAlertas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

            // FormAlertas

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(dgvAlertas);
            Name = "FormAlertas";
            Text = "Alertas";
            Load += FormAlertas_Load;
            ((System.ComponentModel.ISupportInitialize) dgvAlertas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAlertas;
    }
}