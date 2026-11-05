
namespace SistemaPrestamos
{
    partial class FrmPagos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.ComboBox cmbPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;

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

            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();

            this.cmbPrestamo = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();

            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();

            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();

            // FORMULARIO
            this.Name = "FrmPagos";
            this.Text = "Registro de pagos";
            this.ClientSize = new System.Drawing.Size(850, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ENCABEZADO
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(850, 100);

            this.lblTitulo.Text = "REGISTRO DE PAGOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 17);
            this.lblTitulo.AutoSize = true;

            this.lblSubtitulo.Text = "ADMINISTRACIÓN Y CONTROL DE PAGOS DE PRÉSTAMOS";
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(34, 62);
            this.lblSubtitulo.AutoSize = true;

            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);

            // PANEL DE DATOS
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Location = new System.Drawing.Point(30, 125);
            this.pnlDatos.Size = new System.Drawing.Size(790, 325);

            this.lblPrestamo.Text = "Seleccionar préstamo";
            this.lblPrestamo.Location = new System.Drawing.Point(30, 25);
            this.lblPrestamo.AutoSize = true;

            this.cmbPrestamo.Location = new System.Drawing.Point(30, 52);
            this.cmbPrestamo.Size = new System.Drawing.Size(340, 28);
            this.cmbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblFecha.Text = "Fecha del pago";
            this.lblFecha.Location = new System.Drawing.Point(410, 25);
            this.lblFecha.AutoSize = true;

            this.dtpFechaPago.Location = new System.Drawing.Point(410, 52);
            this.dtpFechaPago.Size = new System.Drawing.Size(340, 25);
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblMonto.Text = "Monto pagado (Bs.)";
            this.lblMonto.Location = new System.Drawing.Point(30, 110);
            this.lblMonto.AutoSize = true;

            this.txtMonto.Location = new System.Drawing.Point(30, 137);
            this.txtMonto.Size = new System.Drawing.Size(340, 27);
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.lblMetodo.Text = "Método de pago";
            this.lblMetodo.Location = new System.Drawing.Point(410, 110);
            this.lblMetodo.AutoSize = true;

            this.cmbMetodo.Location = new System.Drawing.Point(410, 137);
            this.cmbMetodo.Size = new System.Drawing.Size(340, 28);
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Items.AddRange(new object[] {
                "Efectivo", "Transferencia", "Depósito", "QR"
            });
            this.cmbMetodo.SelectedIndex = 0;

            this.lblObservacion.Text = "Observaciones";
            this.lblObservacion.Location = new System.Drawing.Point(30, 195);
            this.lblObservacion.AutoSize = true;

            this.txtObservacion.Location = new System.Drawing.Point(30, 222);
            this.txtObservacion.Size = new System.Drawing.Size(720, 55);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.pnlDatos.Controls.Add(this.lblPrestamo);
            this.pnlDatos.Controls.Add(this.cmbPrestamo);
            this.pnlDatos.Controls.Add(this.lblFecha);
            this.pnlDatos.Controls.Add(this.dtpFechaPago);
            this.pnlDatos.Controls.Add(this.lblMonto);
            this.pnlDatos.Controls.Add(this.txtMonto);
            this.pnlDatos.Controls.Add(this.lblMetodo);
            this.pnlDatos.Controls.Add(this.cmbMetodo);
            this.pnlDatos.Controls.Add(this.lblObservacion);
            this.pnlDatos.Controls.Add(this.txtObservacion);

            // RESUMEN
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(230, 234, 240);
            this.pnlResumen.Location = new System.Drawing.Point(30, 465);
            this.pnlResumen.Size = new System.Drawing.Size(790, 65);

            this.lblResumen.Text = "RESUMEN DEL PRÉSTAMO";
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblResumen.Location = new System.Drawing.Point(20, 8);
            this.lblResumen.AutoSize = true;

            this.lblSaldo.Text = "Saldo pendiente: Bs. 0.00";
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.Location = new System.Drawing.Point(20, 32);
            this.lblSaldo.AutoSize = true;

            this.pnlResumen.Controls.Add(this.lblResumen);
            this.pnlResumen.Controls.Add(this.lblSaldo);

            // BOTONES
            this.btnRegistrar.Text = "REGISTRAR PAGO";
            this.btnRegistrar.Location = new System.Drawing.Point(30, 555);
            this.btnRegistrar.Size = new System.Drawing.Size(190, 42);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(38, 150, 105);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;

            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.Location = new System.Drawing.Point(245, 555);
            this.btnLimpiar.Size = new System.Drawing.Size(140, 42);
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(230, 234, 240);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;

            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Location = new System.Drawing.Point(680, 555);
            this.btnCancelar.Size = new System.Drawing.Size(140, 42);
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(190, 65, 65);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;

            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
