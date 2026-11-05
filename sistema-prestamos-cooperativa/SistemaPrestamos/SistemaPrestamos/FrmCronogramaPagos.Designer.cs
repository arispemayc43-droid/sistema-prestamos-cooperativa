
namespace SistemaPrestamos
{
    partial class FrmCronogramaPagos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblValorPrestamo;
        private System.Windows.Forms.Label lblValorSocio;
        private System.Windows.Forms.Label lblValorMonto;
        private System.Windows.Forms.Label lblValorPlazo;
        private System.Windows.Forms.Label lblTituloTabla;
        private System.Windows.Forms.DataGridView dgvCronograma;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblTotalCuotas;
        private System.Windows.Forms.Label lblPagadas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();

            this.lblValorPrestamo = new System.Windows.Forms.Label();
            this.lblValorSocio = new System.Windows.Forms.Label();
            this.lblValorMonto = new System.Windows.Forms.Label();
            this.lblValorPlazo = new System.Windows.Forms.Label();

            this.lblTituloTabla = new System.Windows.Forms.Label();
            this.dgvCronograma = new System.Windows.Forms.DataGridView();

            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblTotalCuotas = new System.Windows.Forms.Label();
            this.lblPagadas = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();

            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();

            // FORMULARIO
            this.Name = "FrmCronogramaPagos";
            this.Text = "Cronograma de pagos";
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ENCABEZADO
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(1080, 100);

            this.lblTitulo.Text = "CRONOGRAMA DE PAGOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 17);
            this.lblTitulo.AutoSize = true;

            this.lblSubtitulo.Text = "SEGUIMIENTO DE CUOTAS Y ESTADO DE PAGOS";
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(34, 62);
            this.lblSubtitulo.AutoSize = true;

            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);

            // INFORMACIÓN DEL PRÉSTAMO
            this.pnlInformacion.BackColor = System.Drawing.Color.White;
            this.pnlInformacion.Location = new System.Drawing.Point(25, 120);
            this.pnlInformacion.Size = new System.Drawing.Size(1030, 125);

            this.lblPrestamo.Text = "N.º DE PRÉSTAMO";
            this.lblPrestamo.Location = new System.Drawing.Point(25, 20);
            this.lblPrestamo.AutoSize = true;

            this.lblValorPrestamo.Text = "Sin seleccionar";
            this.lblValorPrestamo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorPrestamo.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblValorPrestamo.Location = new System.Drawing.Point(25, 48);
            this.lblValorPrestamo.AutoSize = true;

            this.lblSocio.Text = "SOCIO";
            this.lblSocio.Location = new System.Drawing.Point(270, 20);
            this.lblSocio.AutoSize = true;

            this.lblValorSocio.Text = "Sin seleccionar";
            this.lblValorSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorSocio.Location = new System.Drawing.Point(270, 48);
            this.lblValorSocio.AutoSize = true;

            this.lblMonto.Text = "MONTO DEL PRÉSTAMO";
            this.lblMonto.Location = new System.Drawing.Point(540, 20);
            this.lblMonto.AutoSize = true;

            this.lblValorMonto.Text = "Bs. 0.00";
            this.lblValorMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorMonto.ForeColor = System.Drawing.Color.FromArgb(38, 150, 105);
            this.lblValorMonto.Location = new System.Drawing.Point(540, 48);
            this.lblValorMonto.AutoSize = true;

            this.lblPlazo.Text = "PLAZO";
            this.lblPlazo.Location = new System.Drawing.Point(800, 20);
            this.lblPlazo.AutoSize = true;

            this.lblValorPlazo.Text = "0 meses";
            this.lblValorPlazo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorPlazo.Location = new System.Drawing.Point(800, 48);
            this.lblValorPlazo.AutoSize = true;

            this.pnlInformacion.Controls.Add(this.lblPrestamo);
            this.pnlInformacion.Controls.Add(this.lblValorPrestamo);
            this.pnlInformacion.Controls.Add(this.lblSocio);
            this.pnlInformacion.Controls.Add(this.lblValorSocio);
            this.pnlInformacion.Controls.Add(this.lblMonto);
            this.pnlInformacion.Controls.Add(this.lblValorMonto);
            this.pnlInformacion.Controls.Add(this.lblPlazo);
            this.pnlInformacion.Controls.Add(this.lblValorPlazo);

            // TÍTULO TABLA
            this.lblTituloTabla.Text = "DETALLE DE CUOTAS";
            this.lblTituloTabla.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloTabla.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblTituloTabla.Location = new System.Drawing.Point(25, 265);
            this.lblTituloTabla.AutoSize = true;

            // TABLA
            this.dgvCronograma.Location = new System.Drawing.Point(25, 305);
            this.dgvCronograma.Size = new System.Drawing.Size(1030, 230);
            this.dgvCronograma.BackgroundColor = System.Drawing.Color.White;
            this.dgvCronograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCronograma.AllowUserToAddRows = false;
            this.dgvCronograma.AllowUserToDeleteRows = false;
            this.dgvCronograma.ReadOnly = true;
            this.dgvCronograma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCronograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCronograma.RowHeadersVisible = false;
            this.dgvCronograma.EnableHeadersVisualStyles = false;

            this.dgvCronograma.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvCronograma.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCronograma.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCronograma.ColumnHeadersHeight = 40;
            this.dgvCronograma.RowTemplate.Height = 35;

            this.dgvCronograma.Columns.Add("NumeroCuota", "N.º CUOTA");
            this.dgvCronograma.Columns.Add("FechaVencimiento", "FECHA DE VENCIMIENTO");
            this.dgvCronograma.Columns.Add("Capital", "CAPITAL");
            this.dgvCronograma.Columns.Add("Interes", "INTERÉS");
            this.dgvCronograma.Columns.Add("MontoCuota", "MONTO CUOTA");
            this.dgvCronograma.Columns.Add("Saldo", "SALDO");
            this.dgvCronograma.Columns.Add("Estado", "ESTADO");

            // RESUMEN
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.Location = new System.Drawing.Point(25, 555);
            this.pnlResumen.Size = new System.Drawing.Size(1030, 65);

            this.lblTotalCuotas.Text = "TOTAL CUOTAS: 0";
            this.lblTotalCuotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCuotas.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblTotalCuotas.Location = new System.Drawing.Point(25, 24);
            this.lblTotalCuotas.AutoSize = true;

            this.lblPagadas.Text = "PAGADAS: 0";
            this.lblPagadas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPagadas.ForeColor = System.Drawing.Color.FromArgb(38, 150, 105);
            this.lblPagadas.Location = new System.Drawing.Point(350, 24);
            this.lblPagadas.AutoSize = true;

            this.lblPendientes.Text = "PENDIENTES: 0";
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendientes.ForeColor = System.Drawing.Color.FromArgb(190, 65, 65);
            this.lblPendientes.Location = new System.Drawing.Point(700, 24);
            this.lblPendientes.AutoSize = true;

            this.pnlResumen.Controls.Add(this.lblTotalCuotas);
            this.pnlResumen.Controls.Add(this.lblPagadas);
            this.pnlResumen.Controls.Add(this.lblPendientes);

            // BOTONES
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.Location = new System.Drawing.Point(25, 635);
            this.btnActualizar.Size = new System.Drawing.Size(150, 35);
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderSize = 0;

            this.btnVolver.Text = "VOLVER";
            this.btnVolver.Location = new System.Drawing.Point(905, 635);
            this.btnVolver.Size = new System.Drawing.Size(150, 35);
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(230, 234, 240);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(43, 43, 43);
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.FlatAppearance.BorderSize = 0;

            // AGREGAR CONTROLES
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.lblTituloTabla);
            this.Controls.Add(this.dgvCronograma);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVolver);

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
