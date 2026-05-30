namespace SolucionProyecto_PED941.Forms
{
    partial class FormInventario
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
            Guna.UI2.WinForms.Suite.CustomizableEdges ce13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();

            
            panelIzquierdo = new Guna.UI2.WinForms.Guna2Panel();
            panelDerecho = new Guna.UI2.WinForms.Guna2Panel();
            panelIzquierdo.Controls.Add(lblEstado);
            panelIzquierdo.Controls.Add(cmbEstado);

            panelKpiTotal = new Guna.UI2.WinForms.Guna2Panel();
            panelKpiAgotados = new Guna.UI2.WinForms.Guna2Panel();
            panelKpiStockBajo = new Guna.UI2.WinForms.Guna2Panel();
            panelKpiValor = new Guna.UI2.WinForms.Guna2Panel();

            lblKpiTotalLbl = new Label();
            lblKpiTotalProductos = new Label();
            lblKpiAgotadosLbl = new Label();
            lblKpiAgotados = new Label();
            lblKpiStockBajoLbl = new Label();
            lblKpiStockBajo = new Label();
            lblKpiValorLbl = new Label();
            lblKpiValorTotal = new Label();

            panelTabla = new Guna.UI2.WinForms.Guna2Panel();
            dgvInventario = new Guna.UI2.WinForms.Guna2DataGridView();

            panelInferiorDerecho = new Guna.UI2.WinForms.Guna2Panel();
            panelGrafica = new Panel();
            panelAlertas = new Guna.UI2.WinForms.Guna2Panel();
            lblAlertaTitulo = new Label();
            lblAlertaHeaderAgot = new Label();
            lblAlertaHeaderBajo = new Label();

            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            txtStockMaximo = new Guna.UI2.WinForms.Guna2TextBox();
            btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            btnRefrescar = new Guna.UI2.WinForms.Guna2Button();
            lblBuscar = new Label();
            lblStockMaximo = new Label();
            lblTituloFiltros = new Label();

            
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            panelKpiTotal.SuspendLayout();
            panelKpiAgotados.SuspendLayout();
            panelKpiStockBajo.SuspendLayout();
            panelKpiValor.SuspendLayout();
            panelTabla.SuspendLayout();
            panelInferiorDerecho.SuspendLayout();
            panelAlertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();

            
            panelIzquierdo.BackColor = Color.White;
            panelIzquierdo.Controls.Add(lblTituloFiltros);
            panelIzquierdo.Controls.Add(lblBuscar);
            panelIzquierdo.Controls.Add(txtBuscar);
            panelIzquierdo.Controls.Add(lblStockMaximo);
            panelIzquierdo.Controls.Add(txtStockMaximo);
            panelIzquierdo.Controls.Add(btnFiltrar);
            panelIzquierdo.Controls.Add(btnRefrescar);
            panelIzquierdo.CustomizableEdges = ce1;
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Margin = new Padding(0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.ShadowDecoration.CustomizableEdges = ce2;
            panelIzquierdo.Size = new Size(170, 523);
            panelIzquierdo.TabIndex = 0;

            // lblTituloFiltros
            lblTituloFiltros.AutoSize = true;
            lblTituloFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloFiltros.ForeColor = Color.FromArgb(100, 88, 255);
            lblTituloFiltros.Location = new Point(12, 14);
            lblTituloFiltros.Name = "lblTituloFiltros";
            lblTituloFiltros.Text = "Filtros";

            // lblBuscar
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 8F);
            lblBuscar.ForeColor = Color.FromArgb(71, 69, 94);
            lblBuscar.Location = new Point(12, 48);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Text = "Buscar";

            // txtBuscar
            txtBuscar.CustomizableEdges = ce7;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(100, 88, 255);
            txtBuscar.Font = new Font("Segoe UI", 8.5F);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(100, 88, 255);
            txtBuscar.Location = new Point(12, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre o código";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = ce8;
            txtBuscar.Size = new Size(146, 36);
            txtBuscar.TabIndex = 1;

            // lblStockMaximo
            lblStockMaximo.AutoSize = true;
            lblStockMaximo.Font = new Font("Segoe UI", 8F);
            lblStockMaximo.ForeColor = Color.FromArgb(71, 69, 94);
            lblStockMaximo.Location = new Point(12, 114);
            lblStockMaximo.Name = "lblStockMaximo";
            lblStockMaximo.Text = "Stock <=";

            // txtStockMaximo
            txtStockMaximo.CustomizableEdges = ce9;
            txtStockMaximo.DefaultText = "";
            txtStockMaximo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStockMaximo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStockMaximo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStockMaximo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStockMaximo.FocusedState.BorderColor = Color.FromArgb(100, 88, 255);
            txtStockMaximo.Font = new Font("Segoe UI", 8.5F);
            txtStockMaximo.HoverState.BorderColor = Color.FromArgb(100, 88, 255);
            txtStockMaximo.Location = new Point(12, 132);
            txtStockMaximo.Name = "txtStockMaximo";
            txtStockMaximo.PlaceholderText = "Ej: 10";
            txtStockMaximo.SelectedText = "";
            txtStockMaximo.ShadowDecoration.CustomizableEdges = ce10;
            txtStockMaximo.Size = new Size(146, 36);
            txtStockMaximo.TabIndex = 2;

            // btnFiltrar
            btnFiltrar.BorderRadius = 8;
            btnFiltrar.DisabledState.BorderColor = Color.DarkGray;
            btnFiltrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFiltrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFiltrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFiltrar.FillColor = Color.Navy;
            btnFiltrar.Font = new Font("Segoe UI", 8.5F);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(12, 182);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(146, 32);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;

            // btnRefrescar
            btnRefrescar.BorderRadius = 8;
            btnRefrescar.DisabledState.BorderColor = Color.DarkGray;
            btnRefrescar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefrescar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefrescar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefrescar.FillColor = Color.FromArgb(100, 88, 255);
            btnRefrescar.Font = new Font("Segoe UI", 8.5F);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(12, 222);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(146, 32);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Mostrar Todos";
            btnRefrescar.Click += btnRefrescar_Click;


           
            // PANEL DERECHO
            
            panelDerecho.BackColor = Color.FromArgb(247, 247, 252);
            panelDerecho.Controls.Add(panelInferiorDerecho);
            panelDerecho.Controls.Add(panelTabla);
            panelDerecho.Controls.Add(panelKpiValor);
            panelDerecho.Controls.Add(panelKpiStockBajo);
            panelDerecho.Controls.Add(panelKpiAgotados);
            panelDerecho.Controls.Add(panelKpiTotal);
            panelDerecho.CustomizableEdges = ce3;
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(170, 0);
            panelDerecho.Margin = new Padding(0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = ce4;
            panelDerecho.TabIndex = 1;

            
            panelKpiTotal.BackColor = Color.FromArgb(235, 233, 255);
            panelKpiTotal.BorderRadius = 10;
            panelKpiTotal.CustomizableEdges = ce11;
            panelKpiTotal.ShadowDecoration.CustomizableEdges = ce12;
            panelKpiTotal.Controls.Add(lblKpiTotalLbl);
            panelKpiTotal.Controls.Add(lblKpiTotalProductos);
            panelKpiTotal.Location = new Point(10, 10);
            panelKpiTotal.Name = "panelKpiTotal";
            panelKpiTotal.Size = new Size(198, 82);
            panelKpiTotal.TabIndex = 5;

            lblKpiTotalLbl.AutoSize = true;
            lblKpiTotalLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblKpiTotalLbl.ForeColor = Color.FromArgb(100, 88, 255);
            lblKpiTotalLbl.Location = new Point(10, 8);
            lblKpiTotalLbl.Name = "lblKpiTotalLbl";
            lblKpiTotalLbl.Text = "Total productos";

            lblKpiTotalProductos.AutoSize = true;
            lblKpiTotalProductos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiTotalProductos.ForeColor = Color.FromArgb(100, 88, 255);
            lblKpiTotalProductos.Location = new Point(10, 28);
            lblKpiTotalProductos.Name = "lblKpiTotalProductos";
            lblKpiTotalProductos.Text = "0";

            // KPI Agotados
            panelKpiAgotados.BackColor = Color.FromArgb(255, 235, 235);
            panelKpiAgotados.BorderRadius = 10;
            panelKpiAgotados.CustomizableEdges = ce13;
            panelKpiAgotados.ShadowDecoration.CustomizableEdges = ce14;
            panelKpiAgotados.Controls.Add(lblKpiAgotadosLbl);
            panelKpiAgotados.Controls.Add(lblKpiAgotados);
            panelKpiAgotados.Location = new Point(216, 10);
            panelKpiAgotados.Name = "panelKpiAgotados";
            panelKpiAgotados.Size = new Size(198, 82);
            panelKpiAgotados.TabIndex = 6;

            lblKpiAgotadosLbl.AutoSize = true;
            lblKpiAgotadosLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblKpiAgotadosLbl.ForeColor = Color.FromArgb(204, 50, 50);
            lblKpiAgotadosLbl.Location = new Point(10, 8);
            lblKpiAgotadosLbl.Name = "lblKpiAgotadosLbl";
            lblKpiAgotadosLbl.Text = "Agotados";

            lblKpiAgotados.AutoSize = true;
            lblKpiAgotados.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiAgotados.ForeColor = Color.FromArgb(204, 50, 50);
            lblKpiAgotados.Location = new Point(10, 28);
            lblKpiAgotados.Name = "lblKpiAgotados";
            lblKpiAgotados.Text = "0";

            //  KPI Stock bajo 
            panelKpiStockBajo.BackColor = Color.FromArgb(255, 248, 225);
            panelKpiStockBajo.BorderRadius = 10;
            panelKpiStockBajo.CustomizableEdges = ce15;
            panelKpiStockBajo.ShadowDecoration.CustomizableEdges = ce16;
            panelKpiStockBajo.Controls.Add(lblKpiStockBajoLbl);
            panelKpiStockBajo.Controls.Add(lblKpiStockBajo);
            panelKpiStockBajo.Location = new Point(422, 10);
            panelKpiStockBajo.Name = "panelKpiStockBajo";
            panelKpiStockBajo.Size = new Size(198, 82);
            panelKpiStockBajo.TabIndex = 7;

            lblKpiStockBajoLbl.AutoSize = true;
            lblKpiStockBajoLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblKpiStockBajoLbl.ForeColor = Color.FromArgb(185, 120, 0);
            lblKpiStockBajoLbl.Location = new Point(10, 8);
            lblKpiStockBajoLbl.Name = "lblKpiStockBajoLbl";
            lblKpiStockBajoLbl.Text = "Stock bajo";

            lblKpiStockBajo.AutoSize = true;
            lblKpiStockBajo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKpiStockBajo.ForeColor = Color.FromArgb(185, 120, 0);
            lblKpiStockBajo.Location = new Point(10, 28);
            lblKpiStockBajo.Name = "lblKpiStockBajo";
            lblKpiStockBajo.Text = "0";

            // KPI Valor total
            panelKpiValor.BackColor = Color.FromArgb(225, 248, 240);
            panelKpiValor.BorderRadius = 10;
            panelKpiValor.Controls.Add(lblKpiValorLbl);
            panelKpiValor.Controls.Add(lblKpiValorTotal);
            panelKpiValor.Location = new Point(628, 10);
            panelKpiValor.Name = "panelKpiValor";
            panelKpiValor.Size = new Size(198, 82);
            panelKpiValor.TabIndex = 8;

            lblKpiValorLbl.AutoSize = true;
            lblKpiValorLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblKpiValorLbl.ForeColor = Color.FromArgb(0, 110, 70);
            lblKpiValorLbl.Location = new Point(10, 8);
            lblKpiValorLbl.Name = "lblKpiValorLbl";
            lblKpiValorLbl.Text = "Valor total inv.";

            lblKpiValorTotal.AutoSize = true;
            lblKpiValorTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblKpiValorTotal.ForeColor = Color.FromArgb(0, 110, 70);
            lblKpiValorTotal.Location = new Point(10, 30);
            lblKpiValorTotal.Name = "lblKpiValorTotal";
            lblKpiValorTotal.Text = "$0";

            
            // PANEL TABLA
          
            panelTabla.BackColor = Color.White;
            panelTabla.BorderRadius = 10;
            panelTabla.Controls.Add(dgvInventario);
            panelTabla.CustomizableEdges = ce5;
            panelTabla.Location = new Point(10, 104);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(818, 370);
            panelTabla.TabIndex = 20;

            //  DataGridView
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.AllowUserToOrderColumns = true;
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;

            dgvStyle1.BackColor = Color.White;
            dgvInventario.AlternatingRowsDefaultCellStyle = dgvStyle1;

            dgvStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvStyle2.ForeColor = Color.White;
            dgvStyle2.SelectionBackColor = Color.FromArgb(100, 88, 255);
            dgvStyle2.SelectionForeColor = Color.White;
            dgvStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventario.ColumnHeadersDefaultCellStyle = dgvStyle2;
            dgvInventario.ColumnHeadersHeight = 36;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.White;
            dgvStyle3.Font = new Font("Segoe UI", 8.5F);
            dgvStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dgvStyle3;

            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventario.Location = new Point(0, 0);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.RowTemplate.Height = 30;
            dgvInventario.TabIndex = 0;

            dgvInventario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.White;
            dgvInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.ThemeStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventario.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvInventario.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventario.ThemeStyle.HeaderStyle.Height = 36;
            dgvInventario.ThemeStyle.ReadOnly = true;
            dgvInventario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8.5F);
            dgvInventario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventario.ThemeStyle.RowsStyle.Height = 30;
            dgvInventario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

           
            // PANEL INFERIOR DERECHO
           
            panelInferiorDerecho.BackColor = Color.FromArgb(247, 247, 252);
            panelInferiorDerecho.Controls.Add(panelAlertas);
            panelInferiorDerecho.Controls.Add(panelGrafica);
            panelInferiorDerecho.CustomizableEdges = ce6;
            panelInferiorDerecho.Location = new Point(10, 550);
            panelInferiorDerecho.Name = "panelInferiorDerecho";
            panelInferiorDerecho.Size = new Size(818, 195);
            panelInferiorDerecho.TabIndex = 30;

            //  Panel gráfica
            panelGrafica.BackColor = Color.White;
            panelGrafica.Location = new Point(0, 0);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(590, 205);
            panelGrafica.TabIndex = 0;
            panelGrafica.Paint += panelGrafica_Paint;

            //  Panel alertas 
            panelAlertas.BackColor = Color.White;
            panelAlertas.BorderRadius = 10;
            panelAlertas.Controls.Add(lblAlertaTitulo);
            panelAlertas.Controls.Add(lblAlertaHeaderAgot);
            panelAlertas.Controls.Add(lblAlertaHeaderBajo);
            panelAlertas.CustomizableEdges = ce5;
            panelAlertas.Location = new Point(598, 0);
            panelAlertas.Name = "panelAlertas";
            panelAlertas.Size = new Size(220, 185);
            panelAlertas.TabIndex = 1;
            panelAlertas.AutoScroll = true;

            // lblAlertaTitulo
            lblAlertaTitulo.AutoSize = true;
            lblAlertaTitulo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAlertaTitulo.ForeColor = Color.FromArgb(71, 69, 94);
            lblAlertaTitulo.Location = new Point(8, 8);
            lblAlertaTitulo.Name = "lblAlertaTitulo";
            lblAlertaTitulo.Text = "Alertas de inventario";

            // lblAlertaHeaderAgot
            lblAlertaHeaderAgot.AutoSize = false;
            lblAlertaHeaderAgot.Size = new Size(202, 20);
            lblAlertaHeaderAgot.Location = new Point(8, 28);
            lblAlertaHeaderAgot.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblAlertaHeaderAgot.ForeColor = Color.FromArgb(180, 0, 0);
            lblAlertaHeaderAgot.BackColor = Color.FromArgb(255, 220, 220);
            lblAlertaHeaderAgot.Name = "lblAlertaHeaderAgot";
            lblAlertaHeaderAgot.Text = "  ⚠  Agotados";
            lblAlertaHeaderAgot.TextAlign = ContentAlignment.MiddleLeft;

            // lblAlertaHeaderBajo
            lblAlertaHeaderBajo.AutoSize = false;
            lblAlertaHeaderBajo.Size = new Size(202, 20);
            lblAlertaHeaderBajo.Location = new Point(8, 100);
            lblAlertaHeaderBajo.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblAlertaHeaderBajo.ForeColor = Color.FromArgb(160, 100, 0);
            lblAlertaHeaderBajo.BackColor = Color.FromArgb(255, 245, 200);
            lblAlertaHeaderBajo.Name = "lblAlertaHeaderBajo";
            lblAlertaHeaderBajo.Text = "  ⚠  Stock bajo";
            lblAlertaHeaderBajo.TextAlign = ContentAlignment.MiddleLeft;

          
            // FORM 
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 523);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Margin = new Padding(0);
            Name = "FormInventario";
            Text = "Inventario";
            Load += FormInventario_Load;

            //  ResumeLayout
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelKpiTotal.ResumeLayout(false);
            panelKpiTotal.PerformLayout();
            panelKpiAgotados.ResumeLayout(false);
            panelKpiAgotados.PerformLayout();
            panelKpiStockBajo.ResumeLayout(false);
            panelKpiStockBajo.PerformLayout();
            panelKpiValor.ResumeLayout(false);
            panelKpiValor.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelInferiorDerecho.ResumeLayout(false);
            panelAlertas.ResumeLayout(false);
            panelAlertas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelIzquierdo;
        private Guna.UI2.WinForms.Guna2Panel panelDerecho;
        private Guna.UI2.WinForms.Guna2Panel panelKpiTotal;
        private Guna.UI2.WinForms.Guna2Panel panelKpiAgotados;
        private Guna.UI2.WinForms.Guna2Panel panelKpiStockBajo;
        private Guna.UI2.WinForms.Guna2Panel panelKpiValor;
        private Label lblKpiTotalLbl;
        private Label lblKpiTotalProductos;
        private Label lblKpiAgotadosLbl;
        private Label lblKpiAgotados;
        private Label lblKpiStockBajoLbl;
        private Label lblKpiStockBajo;
        private Label lblKpiValorLbl;
        private Label lblKpiValorTotal;
        private Guna.UI2.WinForms.Guna2Panel panelTabla;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventario;
        private Guna.UI2.WinForms.Guna2Panel panelInferiorDerecho;
        private Panel panelGrafica;
        private Guna.UI2.WinForms.Guna2Panel panelAlertas;
        private Label lblAlertaTitulo;
        private Label lblAlertaHeaderAgot;
        private Label lblAlertaHeaderBajo;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtStockMaximo;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnRefrescar;
        private Label lblBuscar;
        private Label lblStockMaximo;
        private Label lblTituloFiltros;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstado;
        private Label lblEstado;
    }
}