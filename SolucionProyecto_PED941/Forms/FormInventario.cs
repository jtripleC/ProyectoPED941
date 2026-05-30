using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SolucionProyecto_PED941.Data.Repositories;
using SolucionProyecto_PED941.Models;

namespace SolucionProyecto_PED941.Forms
{
    public partial class FormInventario : Form
    {
        private readonly ProductoRepository _productoRepository = new ProductoRepository();
        private List<Producto> _todosLosProductos = new List<Producto>();
        private List<Producto> _productosFiltrados = new List<Producto>();

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

            CargarInventario();
        }

       
        // CARGA PRINCIPAL
      

        private void CargarInventario()
        {
            _todosLosProductos = _productoRepository.ObtenerTodos();
            _productosFiltrados = new List<Producto>(_todosLosProductos);

            ActualizarTarjetasKPI(_todosLosProductos);
            MostrarEnGrid(_productosFiltrados);
            ActualizarPanelAlertas(_todosLosProductos);
            panelGrafica.Invalidate();
        }

        
        // TARJETAS KPI
       

        private void ActualizarTarjetasKPI(List<Producto> productos)
        {
            int total = productos.Count;
            int agotados = productos.Count(p => p.Stock == 0);
            int stockBajo = productos.Count(p => p.Stock > 0 && p.Stock <= p.StockMinimo);
            decimal valor = productos.Sum(p => p.Precio * p.Stock);

            lblKpiTotalProductos.Text = total.ToString();
            lblKpiAgotados.Text = agotados.ToString();
            lblKpiStockBajo.Text = stockBajo.ToString();
            lblKpiValorTotal.Text = valor.ToString("C0");
        }

        // DATAGRIDVIEW
       

        private void MostrarEnGrid(List<Producto> productos)
        {
            var vista = productos.Select(p => new
            {
                p.Codigo,
                Producto = p.Nombre,
                p.Precio,
                p.Stock,
                StockMinimo = p.StockMinimo,
                Estado = p.Stock == 0 ? "Agotado"
                             : p.Stock <= p.StockMinimo ? "Bajo"
                             : "OK"
            }).ToList();

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = vista;

            if (dgvInventario.Columns["Codigo"] != null) dgvInventario.Columns["Codigo"].HeaderText = "Código";
            if (dgvInventario.Columns["Producto"] != null) dgvInventario.Columns["Producto"].HeaderText = "Producto";
            if (dgvInventario.Columns["Precio"] != null) dgvInventario.Columns["Precio"].HeaderText = "Precio";
            if (dgvInventario.Columns["Stock"] != null) dgvInventario.Columns["Stock"].HeaderText = "Stock";
            if (dgvInventario.Columns["StockMinimo"] != null) dgvInventario.Columns["StockMinimo"].HeaderText = "Stock Mínimo";
            if (dgvInventario.Columns["Estado"] != null) dgvInventario.Columns["Estado"].HeaderText = "Estado";

            BeginInvoke(new Action(ColorearFilasPorEstado));
        }

        private void ColorearFilasPorEstado()
        {
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (row.Cells["Estado"].Value == null) continue;

                string estado = row.Cells["Estado"].Value.ToString();

                Color colorFondo = estado switch
                {
                    "Agotado" => Color.FromArgb(255, 220, 220),
                    "Bajo" => Color.FromArgb(255, 245, 200),
                    _ => Color.White
                };

                Color colorTexto = estado switch
                {
                    "Agotado" => Color.FromArgb(180, 0, 0),
                    "Bajo" => Color.FromArgb(160, 100, 0),
                    _ => Color.FromArgb(0, 130, 0)
                };

                row.Cells["Estado"].Style.BackColor = colorFondo;
                row.Cells["Estado"].Style.ForeColor = colorTexto;
                row.Cells["Estado"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                row.Cells["Estado"].Style.SelectionBackColor = colorFondo;
                row.Cells["Estado"].Style.SelectionForeColor = colorTexto;
            }
        }

       
        // PANEL DE ALERTAS
        

        private void ActualizarPanelAlertas(List<Producto> productos)
        {
            var agotados = productos.Where(p => p.Stock == 0).ToList();
            var stockBajo = productos.Where(p => p.Stock > 0 && p.Stock <= p.StockMinimo).ToList();

            
            var labelsAEliminar = panelAlertas.Controls
                .OfType<Label>()
                .Where(l => l.Tag?.ToString() == "alerta")
                .ToList();
            foreach (var lbl in labelsAEliminar)
                panelAlertas.Controls.Remove(lbl);

            int y = 54; 

            // Sección: Agotados
            foreach (var p in agotados)
            {
                var lbl = CrearLabelAlerta($"• {p.Nombre}", Color.FromArgb(180, 0, 0), ref y);
                panelAlertas.Controls.Add(lbl);
            }

            if (!agotados.Any())
            {
                var lbl = CrearLabelAlerta("  Sin productos agotados", Color.FromArgb(150, 150, 150), ref y);
                panelAlertas.Controls.Add(lbl);
            }

            y += 6; 

            
            lblAlertaHeaderBajo.Location = new Point(10, y);
            y += lblAlertaHeaderBajo.Height + 6;

            // Sección: Stock bajo
            foreach (var p in stockBajo)
            {
                var lbl = CrearLabelAlerta($"• {p.Nombre}", Color.FromArgb(160, 100, 0), ref y);
                panelAlertas.Controls.Add(lbl);
            }

            if (!stockBajo.Any())
            {
                var lbl = CrearLabelAlerta("  Sin stock bajo", Color.FromArgb(150, 150, 150), ref y);
                panelAlertas.Controls.Add(lbl);
            }
        }

        private Label CrearLabelAlerta(string texto, Color color, ref int y)
        {
            var lbl = new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = color,
                Location = new Point(10, y),
                AutoSize = true,
                Tag = "alerta"
            };
            y += 20;
            return lbl;
        }

        
        // GRÁFICA productos críticos: 5
       

        private void panelGrafica_Paint(object sender, PaintEventArgs e)
        {
            // Solo productos agotados o con stock bajo, máximo 5
            var criticos = _todosLosProductos
                .Where(p => p.Stock == 0 || p.Stock <= p.StockMinimo)
                .OrderBy(p => p.Stock)
                .Take(5)
                .ToList();

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (!criticos.Any())
            {
                // Mensaje cuando no hay críticos
                using var fontMsg = new Font("Segoe UI", 9F, FontStyle.Italic);
                using var brushMsg = new SolidBrush(Color.FromArgb(150, 150, 170));
                string msg = "No hay productos críticos";
                SizeF sz = g.MeasureString(msg, fontMsg);
                g.DrawString(msg, fontMsg, brushMsg,
                    (panelGrafica.Width - sz.Width) / 2,
                    (panelGrafica.Height - sz.Height) / 2);
                return;
            }

            int panelW = panelGrafica.Width;
            int panelH = panelGrafica.Height;
            int padLeft = 44;
            int padRight = 16;
            int padTop = 24;
            int padBottom = 44;

            int chartW = panelW - padLeft - padRight;
            int chartH = panelH - padTop - padBottom;

           
            int maxStock = criticos.Max(p => p.Stock);
            if (maxStock == 0) maxStock = 1;

            using var penGuia = new Pen(Color.FromArgb(231, 229, 255), 1);
            using var fontEje = new Font("Segoe UI", 7.5F);
            using var brushEje = new SolidBrush(Color.FromArgb(150, 150, 170));

            for (int i = 0; i <= 4; i++)
            {
                int y = padTop + (int)(chartH * i / 4.0);
                int val = maxStock - (int)(maxStock * i / 4.0);
                g.DrawLine(penGuia, padLeft, y, padLeft + chartW, y);
                g.DrawString(val.ToString(), fontEje, brushEje, 2, y - 7);
            }

            
            int count = criticos.Count;
            float gap = chartW / (float)count;
            float barW = Math.Max(18, gap * 0.55f);

            for (int i = 0; i < count; i++)
            {
                var p = criticos[i];
                float barH = p.Stock == 0
                    ? chartH * 0.04f                                  
                    : (p.Stock / (float)maxStock) * chartH;

                float x = padLeft + i * gap + (gap - barW) / 2;
                float yB = padTop + chartH - barH;

                Color colorBarra = p.Stock == 0
                    ? Color.FromArgb(220, 80, 80)
                    : Color.FromArgb(255, 180, 50);

                using var brush = new SolidBrush(colorBarra);
                g.FillRectangle(brush, x, yB, barW, barH);

                
                string valor = p.Stock == 0 ? "0" : p.Stock.ToString();
                SizeF szVal = g.MeasureString(valor, fontEje);
                using var bVal = new SolidBrush(p.Stock == 0
                    ? Color.FromArgb(180, 0, 0)
                    : Color.FromArgb(160, 100, 0));
                g.DrawString(valor, fontEje, bVal,
                    x + (barW - szVal.Width) / 2,
                    yB - szVal.Height - 2);

                
                string nombre = p.Nombre.Length > 9 ? p.Nombre.Substring(0, 9) + "." : p.Nombre;
                SizeF szNombre = g.MeasureString(nombre, fontEje);
                g.DrawString(nombre, fontEje, brushEje,
                    x + (barW - szNombre.Width) / 2,
                    padTop + chartH + 6);
            }

            
            using var penEje = new Pen(Color.FromArgb(200, 200, 220), 1);
            g.DrawLine(penEje, padLeft, padTop + chartH, padLeft + chartW, padTop + chartH);

           
            using var fontTitulo = new Font("Segoe UI", 8F, FontStyle.Bold);
            using var bTitulo = new SolidBrush(Color.FromArgb(100, 88, 255));
            g.DrawString("Productos críticos (stock bajo / agotado)", fontTitulo, bTitulo, padLeft, 4);
        }

       
        // FILTROS
       

        private void AplicarFiltros()
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();
            bool tieneRango = int.TryParse(txtStockMaximo.Text.Trim(), out int stockMaximo);

            _productosFiltrados = _todosLosProductos.Where(p =>
            {
                bool coincideTexto = string.IsNullOrEmpty(textoBusqueda)
                    || p.Nombre.ToLower().Contains(textoBusqueda)
                    || p.Codigo.ToLower().Contains(textoBusqueda);

                bool coincideRango = !tieneRango || p.Stock <= stockMaximo;

                return coincideTexto && coincideRango;
            }).ToList();

            MostrarEnGrid(_productosFiltrados);
          
            panelGrafica.Invalidate();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) => AplicarFiltros();

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtStockMaximo.Clear();
            CargarInventario();
        }
    }
}