namespace SolucionProyecto_PED941.Forms
{
    partial class FormHistorial
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
            Guna.UI2.WinForms.Suite.CustomizableEdges ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();

            panelIzquierdo = new Guna.UI2.WinForms.Guna2Panel();
            panelDerecho = new Guna.UI2.WinForms.Guna2Panel();
            dgvHistorial = new Guna.UI2.WinForms.Guna2DataGridView();
            btnRefrescar = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Label();
            lblInfo = new Label();

            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();

            // panelIzquierdo
            panelIzquierdo.BackColor = Color.White;
            panelIzquierdo.Controls.Add(lblTitulo);
            panelIzquierdo.Controls.Add(lblInfo);
            panelIzquierdo.Controls.Add(btnRefrescar);
            panelIzquierdo.CustomizableEdges = ce1;
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(17, 20, 17, 20);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = ce2;
            panelIzquierdo.Size = new Size(200, 646);
            panelIzquierdo.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize = false;
            lblTitulo.Size = new Size(166, 40);
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(100, 88, 255);
            lblTitulo.Location = new Point(17, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Historial de Movimientos";
            lblTitulo.TextAlign = ContentAlignment.TopLeft;

            // lblInfo
            lblInfo.AutoSize = false;
            lblInfo.Size = new Size(166, 60);
            lblInfo.Font = new Font("Segoe UI", 8F);
            lblInfo.ForeColor = Color.FromArgb(120, 120, 140);
            lblInfo.Location = new Point(17, 70);
            lblInfo.Name = "lblInfo";
            lblInfo.Text = "Registro completo de todas las entradas y salidas de inventario.";
            lblInfo.TextAlign = ContentAlignment.TopLeft;

            // btnRefrescar
            btnRefrescar.BorderRadius = 8;
            btnRefrescar.FillColor = Color.FromArgb(100, 88, 255);
            btnRefrescar.Font = new Font("Segoe UI", 9F);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(17, 145);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(166, 36);
            btnRefrescar.TabIndex = 0;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.Click += btnRefrescar_Click;

            // panelDerecho
            panelDerecho.BackColor = Color.White;
            panelDerecho.Controls.Add(dgvHistorial);
            panelDerecho.CustomizableEdges = ce3;
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(200, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Padding = new Padding(11, 13, 11, 13);
            panelDerecho.ShadowDecoration.CustomizableEdges = ce4;
            panelDerecho.TabIndex = 1;

            // dgvHistorial
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.AllowUserToOrderColumns = true;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvStyle1.BackColor = Color.White;
            dgvHistorial.AlternatingRowsDefaultCellStyle = dgvStyle1;
            dgvStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStyle2.ForeColor = Color.White;
            dgvStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.SelectionForeColor = Color.White;
            dgvStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dgvStyle2;
            dgvHistorial.ColumnHeadersHeight = 40;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.White;
            dgvStyle3.Font = new Font("Segoe UI", 9F);
            dgvStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dgvStyle3;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.GridColor = Color.FromArgb(231, 229, 255);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowTemplate.Height = 35;
            dgvHistorial.TabIndex = 0;
            dgvHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.White;
            dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHistorial.ThemeStyle.BackColor = Color.White;
            dgvHistorial.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHistorial.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHistorial.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorial.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHistorial.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHistorial.ThemeStyle.HeaderStyle.Height = 40;
            dgvHistorial.ThemeStyle.ReadOnly = true;
            dgvHistorial.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHistorial.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorial.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHistorial.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHistorial.ThemeStyle.RowsStyle.Height = 35;
            dgvHistorial.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHistorial.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

            // FormHistorial
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 646);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;

            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelIzquierdo;
        private Guna.UI2.WinForms.Guna2Panel panelDerecho;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorial;
        private Guna.UI2.WinForms.Guna2Button btnRefrescar;
        private Label lblTitulo;
        private Label lblInfo;
    }
}