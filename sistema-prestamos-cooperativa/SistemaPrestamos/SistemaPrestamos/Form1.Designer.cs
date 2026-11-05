namespace SistemaPrestamos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpSocio = new System.Windows.Forms.GroupBox();
            this.tlpSocio = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoSocio = new System.Windows.Forms.Label();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.lblIngresoSocio = new System.Windows.Forms.Label();
            this.txtIngresoSocio = new System.Windows.Forms.TextBox();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.grpPrestamo = new System.Windows.Forms.GroupBox();
            this.tlpPrestamo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblTasa = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.lblRangoMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.lblRangoPlazo = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.cboGarantia = new System.Windows.Forms.ComboBox();
            this.lblRequisito = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.grpSocio.SuspendLayout();
            this.tlpSocio.SuspendLayout();
            this.grpPrestamo.SuspendLayout();
            this.tlpPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(804, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud de préstamo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpSocio, 0, 0);
            this.tlpMain.Controls.Add(this.grpPrestamo, 0, 1);
            this.tlpMain.Controls.Add(this.tlpBotones, 0, 2);
            this.tlpMain.Controls.Add(this.dgvSolicitudes, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 60);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(804, 541);
            this.tlpMain.TabIndex = 1;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // grpSocio
            // 
            this.grpSocio.Controls.Add(this.tlpSocio);
            this.grpSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpSocio.Location = new System.Drawing.Point(23, 18);
            this.grpSocio.Name = "grpSocio";
            this.grpSocio.Size = new System.Drawing.Size(758, 74);
            this.grpSocio.TabIndex = 0;
            this.grpSocio.TabStop = false;
            this.grpSocio.Text = "Socio";
            // 
            // tlpSocio
            // 
            this.tlpSocio.ColumnCount = 7;
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSocio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpSocio.Controls.Add(this.lblCodigoSocio, 0, 0);
            this.tlpSocio.Controls.Add(this.txtCodigoSocio, 1, 0);
            this.tlpSocio.Controls.Add(this.btnBuscarSocio, 2, 0);
            this.tlpSocio.Controls.Add(this.txtNombreSocio, 4, 0);
            this.tlpSocio.Controls.Add(this.lblIngresoSocio, 5, 0);
            this.tlpSocio.Controls.Add(this.txtIngresoSocio, 6, 0);
            this.tlpSocio.Controls.Add(this.lblNombreSocio, 3, 0);
            this.tlpSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tlpSocio.Location = new System.Drawing.Point(3, 21);
            this.tlpSocio.Name = "tlpSocio";
            this.tlpSocio.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tlpSocio.RowCount = 1;
            this.tlpSocio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSocio.Size = new System.Drawing.Size(752, 50);
            this.tlpSocio.TabIndex = 0;
            // 
            // lblCodigoSocio
            // 
            this.lblCodigoSocio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigoSocio.AutoSize = true;
            this.lblCodigoSocio.Location = new System.Drawing.Point(11, 15);
            this.lblCodigoSocio.Name = "lblCodigoSocio";
            this.lblCodigoSocio.Size = new System.Drawing.Size(56, 19);
            this.lblCodigoSocio.TabIndex = 0;
            this.lblCodigoSocio.Text = "Código:";
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoSocio.Location = new System.Drawing.Point(73, 12);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.Size = new System.Drawing.Size(94, 25);
            this.txtCodigoSocio.TabIndex = 1;
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBuscarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSocio.FlatAppearance.BorderSize = 0;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSocio.Location = new System.Drawing.Point(178, 8);
            this.btnBuscarSocio.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(115, 34);
            this.btnBuscarSocio.TabIndex = 2;
            this.btnBuscarSocio.Text = "Buscar socio";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreSocio.Location = new System.Drawing.Point(383, 12);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(152, 25);
            this.txtNombreSocio.TabIndex = 4;
            this.txtNombreSocio.TextChanged += new System.EventHandler(this.txtNombreSocio_TextChanged);
            // 
            // lblIngresoSocio
            // 
            this.lblIngresoSocio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIngresoSocio.AutoSize = true;
            this.lblIngresoSocio.Location = new System.Drawing.Point(553, 15);
            this.lblIngresoSocio.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblIngresoSocio.Name = "lblIngresoSocio";
            this.lblIngresoSocio.Size = new System.Drawing.Size(58, 19);
            this.lblIngresoSocio.TabIndex = 5;
            this.lblIngresoSocio.Text = "Ingreso:";
            // 
            // txtIngresoSocio
            // 
            this.txtIngresoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngresoSocio.Location = new System.Drawing.Point(617, 12);
            this.txtIngresoSocio.Name = "txtIngresoSocio";
            this.txtIngresoSocio.ReadOnly = true;
            this.txtIngresoSocio.Size = new System.Drawing.Size(124, 25);
            this.txtIngresoSocio.TabIndex = 6;
            this.txtIngresoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Location = new System.Drawing.Point(315, 15);
            this.lblNombreSocio.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(62, 19);
            this.lblNombreSocio.TabIndex = 3;
            this.lblNombreSocio.Text = "Nombre:";
            // 
            // grpPrestamo
            // 
            this.grpPrestamo.Controls.Add(this.tlpPrestamo);
            this.grpPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpPrestamo.Location = new System.Drawing.Point(23, 98);
            this.grpPrestamo.Name = "grpPrestamo";
            this.grpPrestamo.Size = new System.Drawing.Size(758, 204);
            this.grpPrestamo.TabIndex = 1;
            this.grpPrestamo.TabStop = false;
            this.grpPrestamo.Text = "Datos del préstamo";
            // 
            // tlpPrestamo
            // 
            this.tlpPrestamo.ColumnCount = 8;
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPrestamo.Controls.Add(this.lblTipo, 0, 0);
            this.tlpPrestamo.Controls.Add(this.cboTipoPrestamo, 1, 0);
            this.tlpPrestamo.Controls.Add(this.lblTasa, 2, 0);
            this.tlpPrestamo.Controls.Add(this.txtTasa, 3, 0);
            this.tlpPrestamo.Controls.Add(this.lblFecha, 4, 0);
            this.tlpPrestamo.Controls.Add(this.dtpFecha, 5, 0);
            this.tlpPrestamo.Controls.Add(this.lblEstado, 6, 0);
            this.tlpPrestamo.Controls.Add(this.txtEstado, 7, 0);
            this.tlpPrestamo.Controls.Add(this.lblMonto, 0, 1);
            this.tlpPrestamo.Controls.Add(this.nudMonto, 1, 1);
            this.tlpPrestamo.Controls.Add(this.lblRangoMonto, 2, 1);
            this.tlpPrestamo.Controls.Add(this.lblPlazo, 0, 2);
            this.tlpPrestamo.Controls.Add(this.nudPlazo, 1, 2);
            this.tlpPrestamo.Controls.Add(this.lblRangoPlazo, 2, 2);
            this.tlpPrestamo.Controls.Add(this.lblGarantia, 4, 2);
            this.tlpPrestamo.Controls.Add(this.cboGarantia, 5, 2);
            this.tlpPrestamo.Controls.Add(this.lblRequisito, 0, 3);
            this.tlpPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tlpPrestamo.Location = new System.Drawing.Point(3, 21);
            this.tlpPrestamo.Name = "tlpPrestamo";
            this.tlpPrestamo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tlpPrestamo.RowCount = 4;
            this.tlpPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tlpPrestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpPrestamo.Size = new System.Drawing.Size(752, 180);
            this.tlpPrestamo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 13);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipoPrestamo
            // 
            this.cboTipoPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPrestamo.FormattingEnabled = true;
            this.cboTipoPrestamo.Location = new System.Drawing.Point(111, 12);
            this.cboTipoPrestamo.Name = "cboTipoPrestamo";
            this.cboTipoPrestamo.Size = new System.Drawing.Size(111, 25);
            this.cboTipoPrestamo.TabIndex = 1;
            this.cboTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cboTipoPrestamo_SelectedIndexChanged);
            // 
            // lblTasa
            // 
            this.lblTasa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(240, 13);
            this.lblTasa.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(74, 19);
            this.lblTasa.TabIndex = 2;
            this.lblTasa.Text = "Tasa anual:";
            // 
            // txtTasa
            // 
            this.txtTasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTasa.Location = new System.Drawing.Point(320, 10);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.ReadOnly = true;
            this.txtTasa.Size = new System.Drawing.Size(52, 25);
            this.txtTasa.TabIndex = 3;
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(390, 13);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 19);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(460, 10);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(91, 25);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(569, 13);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(628, 10);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(113, 25);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.Text = "Pendiente";
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(11, 58);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(80, 19);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto (Bs):";
            // 
            // nudMonto
            // 
            this.nudMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMonto.Location = new System.Drawing.Point(111, 55);
            this.nudMonto.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(111, 25);
            this.nudMonto.TabIndex = 9;
            this.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMonto.ThousandsSeparator = true;
            // 
            // lblRangoMonto
            // 
            this.lblRangoMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRangoMonto.AutoSize = true;
            this.tlpPrestamo.SetColumnSpan(this.lblRangoMonto, 6);
            this.lblRangoMonto.ForeColor = System.Drawing.Color.Gray;
            this.lblRangoMonto.Location = new System.Drawing.Point(240, 58);
            this.lblRangoMonto.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblRangoMonto.Name = "lblRangoMonto";
            this.lblRangoMonto.Size = new System.Drawing.Size(100, 19);
            this.lblRangoMonto.TabIndex = 10;
            this.lblRangoMonto.Text = "Rango: Bs - a -";
            // 
            // lblPlazo
            // 
            this.lblPlazo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(11, 105);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(94, 19);
            this.lblPlazo.TabIndex = 11;
            this.lblPlazo.Text = "Plazo (meses):";
            // 
            // nudPlazo
            // 
            this.nudPlazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPlazo.Location = new System.Drawing.Point(111, 102);
            this.nudPlazo.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(111, 25);
            this.nudPlazo.TabIndex = 12;
            this.nudPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRangoPlazo
            // 
            this.lblRangoPlazo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRangoPlazo.AutoSize = true;
            this.tlpPrestamo.SetColumnSpan(this.lblRangoPlazo, 2);
            this.lblRangoPlazo.ForeColor = System.Drawing.Color.Gray;
            this.lblRangoPlazo.Location = new System.Drawing.Point(240, 105);
            this.lblRangoPlazo.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblRangoPlazo.Name = "lblRangoPlazo";
            this.lblRangoPlazo.Size = new System.Drawing.Size(124, 19);
            this.lblRangoPlazo.TabIndex = 13;
            this.lblRangoPlazo.Text = "Rango: - a - meses";
            // 
            // lblGarantia
            // 
            this.lblGarantia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(390, 105);
            this.lblGarantia.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(64, 19);
            this.lblGarantia.TabIndex = 14;
            this.lblGarantia.Text = "Garantía:";
            // 
            // cboGarantia
            // 
            this.cboGarantia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPrestamo.SetColumnSpan(this.cboGarantia, 3);
            this.cboGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGarantia.FormattingEnabled = true;
            this.cboGarantia.Location = new System.Drawing.Point(460, 104);
            this.cboGarantia.Name = "cboGarantia";
            this.cboGarantia.Size = new System.Drawing.Size(281, 25);
            this.cboGarantia.TabIndex = 15;
            // 
            // lblRequisito
            // 
            this.lblRequisito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRequisito.AutoSize = true;
            this.tlpPrestamo.SetColumnSpan(this.lblRequisito, 8);
            this.lblRequisito.ForeColor = System.Drawing.Color.Gray;
            this.lblRequisito.Location = new System.Drawing.Point(11, 150);
            this.lblRequisito.Name = "lblRequisito";
            this.lblRequisito.Size = new System.Drawing.Size(78, 19);
            this.lblRequisito.TabIndex = 16;
            this.lblRequisito.Text = "Requisito: -";
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 5;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpBotones.Controls.Add(this.btnNuevo, 0, 0);
            this.tlpBotones.Controls.Add(this.btnGuardar, 1, 0);
            this.tlpBotones.Controls.Add(this.btnCancelar, 2, 0);
            this.tlpBotones.Controls.Add(this.btnDocumentos, 4, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(23, 308);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(758, 49);
            this.tlpBotones.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(3, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(118, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(233, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnDocumentos.Location = new System.Drawing.Point(535, 6);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(220, 36);
            this.btnDocumentos.TabIndex = 3;
            this.btnDocumentos.Text = "Documentos y garantías";
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.ColumnHeadersHeight = 36;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudes.EnableHeadersVisualStyles = false;
            this.dgvSolicitudes.Location = new System.Drawing.Point(23, 363);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(758, 155);
            this.dgvSolicitudes.TabIndex = 3;
            this.dgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(804, 601);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(820, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de préstamo";
            this.Load += new System.EventHandler(this.FrmSolicitudPrestamo_Load);
            this.tlpMain.ResumeLayout(false);
            this.grpSocio.ResumeLayout(false);
            this.tlpSocio.ResumeLayout(false);
            this.tlpSocio.PerformLayout();
            this.grpPrestamo.ResumeLayout(false);
            this.tlpPrestamo.ResumeLayout(false);
            this.tlpPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpSocio;
        private System.Windows.Forms.TableLayoutPanel tlpSocio;
        private System.Windows.Forms.Label lblCodigoSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Label lblIngresoSocio;
        private System.Windows.Forms.TextBox txtIngresoSocio;
        private System.Windows.Forms.GroupBox grpPrestamo;
        private System.Windows.Forms.TableLayoutPanel tlpPrestamo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipoPrestamo;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label lblRangoMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.Label lblRangoPlazo;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.ComboBox cboGarantia;
        private System.Windows.Forms.Label lblRequisito;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
    }
}