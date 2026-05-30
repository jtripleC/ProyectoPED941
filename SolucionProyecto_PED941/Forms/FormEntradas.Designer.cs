namespace SolucionProyecto_PED941.Forms
{
    partial class FormEntradas
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
            Guna.UI2.WinForms.Suite.CustomizableEdges ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();

            // Controles
            panelIzquierdo = new Guna.UI2.WinForms.Guna2Panel();
            panelDerecho = new Guna.UI2.WinForms.Guna2Panel();
            cmbProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            btnRegistrarEntrada = new Guna.UI2.WinForms.Guna2Button();
            btnDeshacer = new Guna.UI2.WinForms.Guna2Button();
            dgvMovimientos = new Guna.UI2.WinForms.Guna2DataGridView();
            lblProducto = new Label();
            lblCantidad = new Label();

            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();

            // panelIzquierdo
            panelIzquierdo.BackColor = Color.White;
            panelIzquierdo.Controls.Add(lblProducto);
            panelIzquierdo.Controls.Add(cmbProducto);
            panelIzquierdo.Controls.Add(lblCantidad);
            panelIzquierdo.Controls.Add(txtCantidad);
            panelIzquierdo.Controls.Add(btnRegistrarEntrada);
            panelIzquierdo.Controls.Add(btnDeshacer);
            panelIzquierdo.CustomizableEdges = ce1;
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Margin = new Padding(3, 4, 3, 4);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(17, 20, 17, 20);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = ce2;
            panelIzquierdo.Size = new Size(400, 646);
            panelIzquierdo.TabIndex = 0;

            // panelDerecho
            panelDerecho.BackColor = Color.White;
            panelDerecho.Controls.Add(dgvMovimientos);
            panelDerecho.CustomizableEdges = ce3;
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(400, 0);
            panelDerecho.Margin = new Padding(3, 4, 3, 4);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Padding = new Padding(11, 13, 11, 13);
            panelDerecho.ShadowDecoration.CustomizableEdges = ce4;
            panelDerecho.Size = new Size(734, 646);
            panelDerecho.TabIndex = 1;

            // lblProducto
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F);
            lblProducto.Location = new Point(50, 120);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(70, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";

            // cmbProducto
            cmbProducto.CustomizableEdges = ce5;
            cmbProducto.DrawMode = DrawMode.OwnerDrawFixed;
            cmbProducto.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbProducto.Font = new Font("Segoe UI", 9F);
            cmbProducto.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbProducto.Location = new Point(151, 108);
            cmbProducto.Margin = new Padding(3, 5, 3, 5);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.ShadowDecoration.CustomizableEdges = ce6;
            cmbProducto.Size = new Size(229, 48);
            cmbProducto.TabIndex = 1;

            // lblCantidad
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.Location = new Point(50, 184);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";

            // txtCantidad
            txtCantidad.CustomizableEdges = ce7;
            txtCantidad.DefaultText = "";
            txtCantidad.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCantidad.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCantidad.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCantidad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Font = new Font("Segoe UI", 9F);
            txtCantidad.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCantidad.Location = new Point(151, 172);
            txtCantidad.Margin = new Padding(3, 5, 3, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad a Ingresar";
            txtCantidad.SelectedText = "";
            txtCantidad.ShadowDecoration.CustomizableEdges = ce8;
            txtCantidad.Size = new Size(229, 48);
            txtCantidad.TabIndex = 3;

            // btnRegistrarEntrada
            btnRegistrarEntrada.BorderRadius = 10;
            btnRegistrarEntrada.CustomizableEdges = ce9;
            btnRegistrarEntrada.DisabledState.BorderColor = Color.DarkGray;
            btnRegistrarEntrada.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegistrarEntrada.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegistrarEntrada.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegistrarEntrada.FillColor = Color.Navy;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 9F);
            btnRegistrarEntrada.ForeColor = Color.White;
            btnRegistrarEntrada.Location = new Point(95, 260);
            btnRegistrarEntrada.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.ShadowDecoration.CustomizableEdges = ce10;
            btnRegistrarEntrada.Size = new Size(229, 37);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.Click += btnRegistrarEntrada_Click;

            // btnDeshacer
            btnDeshacer.BorderRadius = 10;
            btnDeshacer.CustomizableEdges = ce11;
            btnDeshacer.DisabledState.BorderColor = Color.DarkGray;
            btnDeshacer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeshacer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeshacer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeshacer.FillColor = Color.Red;
            btnDeshacer.Font = new Font("Segoe UI", 9F);
            btnDeshacer.ForeColor = Color.White;
            btnDeshacer.Location = new Point(95, 320);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.ShadowDecoration.CustomizableEdges = ce12;
            btnDeshacer.Size = new Size(229, 37);
            btnDeshacer.TabIndex = 5;
            btnDeshacer.Text = "Deshacer Última Operación";
            btnDeshacer.Click += btnDeshacer_Click;


            // dgvMovimientos
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AllowUserToResizeRows = false;
            dgvMovimientos.AllowUserToOrderColumns = true;
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.MultiSelect = false;
            dgvStyle1.BackColor = Color.White;
            dgvMovimientos.AlternatingRowsDefaultCellStyle = dgvStyle1;
            dgvStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStyle2.ForeColor = Color.White;
            dgvStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.SelectionForeColor = Color.White;
            dgvStyle2.WrapMode = DataGridViewTriState.True;
            dgvMovimientos.ColumnHeadersDefaultCellStyle = dgvStyle2;
            dgvMovimientos.ColumnHeadersHeight = 40;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.White;
            dgvStyle3.Font = new Font("Segoe UI", 9F);
            dgvStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.WrapMode = DataGridViewTriState.False;
            dgvMovimientos.DefaultCellStyle = dgvStyle3;
            dgvMovimientos.Dock = DockStyle.Fill;
            dgvMovimientos.GridColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.Location = new Point(11, 13);
            dgvMovimientos.Margin = new Padding(3, 4, 3, 4);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.RowTemplate.Height = 35;
            dgvMovimientos.Size = new Size(712, 620);
            dgvMovimientos.TabIndex = 0;
            dgvMovimientos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMovimientos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMovimientos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMovimientos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMovimientos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMovimientos.ThemeStyle.HeaderStyle.Height = 40;
            dgvMovimientos.ThemeStyle.ReadOnly = true;
            dgvMovimientos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMovimientos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovimientos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMovimientos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMovimientos.ThemeStyle.RowsStyle.Height = 35;
            dgvMovimientos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMovimientos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);



            // FormSalidas
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 646);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEntradas";
            Text = "FormEntradas";
            Load += FormEntradas_Load;

            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelIzquierdo;
        private Guna.UI2.WinForms.Guna2Panel panelDerecho;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarEntrada;
        private Guna.UI2.WinForms.Guna2Button btnDeshacer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMovimientos;
        private Label lblProducto;
        private Label lblCantidad;
    }
}