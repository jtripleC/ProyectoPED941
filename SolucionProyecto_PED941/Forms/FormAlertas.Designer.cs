namespace SolucionProyecto_PED941.Forms
{
    partial class FormAlertas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvAlertas = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
            SuspendLayout();
            // 
            // dgvAlertas
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvAlertas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAlertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAlertas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAlertas.Dock = DockStyle.Fill;
            dgvAlertas.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.Location = new Point(0, 0);
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.RowHeadersVisible = false;
            dgvAlertas.Size = new Size(800, 397);
            dgvAlertas.TabIndex = 0;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAlertas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAlertas.ThemeStyle.BackColor = Color.White;
            dgvAlertas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAlertas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAlertas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAlertas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAlertas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertas.ThemeStyle.HeaderStyle.Height = 4;
            dgvAlertas.ThemeStyle.ReadOnly = false;
            dgvAlertas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAlertas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlertas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAlertas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAlertas.ThemeStyle.RowsStyle.Height = 25;
            dgvAlertas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAlertas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FormAlertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(dgvAlertas);
            Name = "FormAlertas";
            Text = "FormAlertas";
            Load += FormAlertas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAlertas;
    }
}