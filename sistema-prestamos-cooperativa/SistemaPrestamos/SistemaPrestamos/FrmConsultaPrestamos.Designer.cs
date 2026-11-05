
namespace SistemaPrestamos
{
    partial class FrmConsultaPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoPrestamo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCronograma;
        private System.Windows.Forms.Button btnSalir;

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

            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.lblListado = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();

            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();

            // FORMULARIO
            this.Text = "Consulta de préstamos";
            this.Name = "FrmConsultaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ENCABEZADO
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(1080, 100);

            this.lblTitulo.Text = "SISTEMA DE PRÉSTAMOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(30, 17);

            this.lblSubtitulo.Text = "CONSULTA Y ADMINISTRACIÓN DE PRÉSTAMOS";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(34, 62);

            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);

            // FILTROS
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Location = new System.Drawing.Point(25, 120);
            this.pnlFiltros.Size = new System.Drawing.Size(1030, 135);

            this.lblBuscar.Text = "Buscar socio";
            this.lblBuscar.Location = new System.Drawing.Point(25, 17);
            this.lblBuscar.AutoSize = true;

            this.txtBuscarSocio.Location = new System.Drawing.Point(25, 45);
            this.txtBuscarSocio.Size = new System.Drawing.Size(250, 27);
            this.txtBuscarSocio.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblTipo.Text = "Tipo de préstamo";
            this.lblTipo.Location = new System.Drawing.Point(310, 17);
            this.lblTipo.AutoSize = true;

            this.cmbTipoPrestamo.Location = new System.Drawing.Point(310, 45);
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(200, 27);
            this.cmbTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrestamo.Items.AddRange(new object[] {
                "Todos", "Personal", "Hipotecario", "Comercial"
            });
            this.cmbTipoPrestamo.SelectedIndex = 0;

            this.lblEstado.Text = "Estado";
            this.lblEstado.Location = new System.Drawing.Point(545, 17);
            this.lblEstado.AutoSize = true;

            this.cmbEstado.Location = new System.Drawing.Point(545, 45);
            this.cmbEstado.Size = new System.Drawing.Size(160, 27);
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
                "Todos", "Activo", "Pendiente", "Cancelado"
            });
            this.cmbEstado.SelectedIndex = 0;

            // BOTONES
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.Location = new System.Drawing.Point(740, 42);
            this.btnBuscar.Size = new System.Drawing.Size(120, 38);
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;

            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Location = new System.Drawing.Point(875, 42);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(230, 234, 240);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;

            this.pnlFiltros.Controls.Add(this.lblBuscar);
            this.pnlFiltros.Controls.Add(this.txtBuscarSocio);
            this.pnlFiltros.Controls.Add(this.lblTipo);
            this.pnlFiltros.Controls.Add(this.cmbTipoPrestamo);
            this.pnlFiltros.Controls.Add(this.lblEstado);
            this.pnlFiltros.Controls.Add(this.cmbEstado);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.btnLimpiar);

            // LISTADO
            this.lblListado.Text = "LISTADO DE PRÉSTAMOS";
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblListado.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblListado.Location = new System.Drawing.Point(25, 275);
            this.lblListado.AutoSize = true;

            // TABLA
            this.dgvPrestamos.Location = new System.Drawing.Point(25, 315);
            this.dgvPrestamos.Size = new System.Drawing.Size(1030, 225);
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;

            this.dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvPrestamos.ColumnHeadersHeight = 40;
            this.dgvPrestamos.RowTemplate.Height = 35;

            this.dgvPrestamos.Columns.Add("IdPrestamo", "N.º PRÉSTAMO");
            this.dgvPrestamos.Columns.Add("Socio", "SOCIO");
            this.dgvPrestamos.Columns.Add("Tipo", "TIPO");
            this.dgvPrestamos.Columns.Add("Monto", "MONTO");
            this.dgvPrestamos.Columns.Add("Plazo", "PLAZO");
            this.dgvPrestamos.Columns.Add("Saldo", "SALDO PENDIENTE");
            this.dgvPrestamos.Columns.Add("Estado", "ESTADO");

            // PANEL INFERIOR
            this.pnlAcciones.Location = new System.Drawing.Point(25, 560);
            this.pnlAcciones.Size = new System.Drawing.Size(1030, 65);
            this.pnlAcciones.BackColor = System.Drawing.Color.White;

            this.btnRegistrarPago.Text = "REGISTRAR PAGO";
            this.btnRegistrarPago.Location = new System.Drawing.Point(25, 15);
            this.btnRegistrarPago.Size = new System.Drawing.Size(180, 38);
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(38, 150, 105);
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;

            this.btnCronograma.Text = "VER CRONOGRAMA";
            this.btnCronograma.Location = new System.Drawing.Point(220, 15);
            this.btnCronograma.Size = new System.Drawing.Size(190, 38);
            this.btnCronograma.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnCronograma.ForeColor = System.Drawing.Color.White;
            this.btnCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronograma.FlatAppearance.BorderSize = 0;

            this.btnSalir.Text = "SALIR";
            this.btnSalir.Location = new System.Drawing.Point(900, 15);
            this.btnSalir.Size = new System.Drawing.Size(100, 38);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(190, 65, 65);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;

            this.pnlAcciones.Controls.Add(this.btnRegistrarPago);
            this.pnlAcciones.Controls.Add(this.btnCronograma);
            this.pnlAcciones.Controls.Add(this.btnSalir);

            // AGREGAR CONTROLES AL FORMULARIO
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.pnlAcciones);

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
