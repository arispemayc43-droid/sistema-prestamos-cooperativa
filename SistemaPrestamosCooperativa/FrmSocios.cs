
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPrestamosCooperativa
{
    public partial class FrmSocios : Form
    {
        private Color azul = Color.FromArgb(31, 58, 95);
        private Color verde = Color.FromArgb(46, 158, 107);
        private Color fondo = Color.FromArgb(244, 246, 249);
        private Color gris = Color.FromArgb(100, 110, 125);

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtCI;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtIngreso;
        private TextBox txtBuscar;

        private DataGridView dgvSocios;

        public FrmSocios()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            this.Controls.Clear();

            this.Text = "Gestión de socios - Cooperativa";
            this.Size = new Size(1280, 800);
            this.MinimumSize = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = fondo;
            this.Font = new Font("Segoe UI", 9F);

            // ENCABEZADO
            Panel encabezado = new Panel();
            encabezado.Dock = DockStyle.Top;
            encabezado.Height = 100;
            encabezado.BackColor = azul;

            Label logo = new Label();
            logo.Text = "SC";
            logo.Location = new Point(28, 19);
            logo.Size = new Size(62, 62);
            logo.BackColor = verde;
            logo.ForeColor = Color.White;
            logo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            logo.TextAlign = ContentAlignment.MiddleCenter;

            Label titulo = new Label();
            titulo.Text = "GESTIÓN DE SOCIOS";
            titulo.Location = new Point(110, 20);
            titulo.Size = new Size(650, 35);
            titulo.ForeColor = Color.White;
            titulo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);

            Label subtitulo = new Label();
            subtitulo.Text = "Administración y registro de socios de la cooperativa";
            subtitulo.Location = new Point(112, 58);
            subtitulo.Size = new Size(650, 25);
            subtitulo.ForeColor = Color.WhiteSmoke;
            subtitulo.Font = new Font("Segoe UI", 10F);

            encabezado.Controls.Add(logo);
            encabezado.Controls.Add(titulo);
            encabezado.Controls.Add(subtitulo);

            // DISTRIBUCIÓN PRINCIPAL
            TableLayoutPanel contenido = new TableLayoutPanel();
            contenido.Dock = DockStyle.Fill;
            contenido.ColumnCount = 2;
            contenido.RowCount = 1;
            contenido.Padding = new Padding(22);
            contenido.BackColor = fondo;

            contenido.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 36F));

            contenido.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 64F));

            contenido.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));

            // PANEL DE REGISTRO
            Panel panelDatos = new Panel();
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.BackColor = Color.White;
            panelDatos.BorderStyle = BorderStyle.FixedSingle;
            panelDatos.Margin = new Padding(0, 0, 18, 0);

            Label tituloDatos = CrearEtiqueta(
                "Información del socio", 20, 18, 330);

            tituloDatos.Font = new Font(
                "Segoe UI", 15F, FontStyle.Bold);

            Label descripcion = CrearEtiqueta(
                "Completa los datos para registrar un socio.",
                20, 50, 340);

            descripcion.ForeColor = gris;

            panelDatos.Controls.Add(tituloDatos);
            panelDatos.Controls.Add(descripcion);

            // CAMPOS
            panelDatos.Controls.Add(
                CrearEtiqueta("Código del socio", 20, 90, 330));

            txtCodigo = CrearCampo(20, 112, 330);
            panelDatos.Controls.Add(txtCodigo);

            panelDatos.Controls.Add(
                CrearEtiqueta("Nombre completo", 20, 151, 330));

            txtNombre = CrearCampo(20, 173, 330);
            panelDatos.Controls.Add(txtNombre);

            panelDatos.Controls.Add(
                CrearEtiqueta("Carnet de identidad (CI)", 20, 212, 330));

            txtCI = CrearCampo(20, 234, 330);
            panelDatos.Controls.Add(txtCI);

            panelDatos.Controls.Add(
                CrearEtiqueta("Dirección", 20, 273, 330));

            txtDireccion = CrearCampo(20, 295, 330);
            panelDatos.Controls.Add(txtDireccion);

            panelDatos.Controls.Add(
                CrearEtiqueta("Teléfono", 20, 334, 330));

            txtTelefono = CrearCampo(20, 356, 330);
            panelDatos.Controls.Add(txtTelefono);

            panelDatos.Controls.Add(
                CrearEtiqueta("Ingreso mensual (Bs.)", 20, 395, 330));

            txtIngreso = CrearCampo(20, 417, 330);
            panelDatos.Controls.Add(txtIngreso);

            // BOTONES
            Button btnGuardar = CrearBoton(
                "GUARDAR", verde, 20, 470);

            Button btnLimpiar = CrearBoton(
                "LIMPIAR", Color.FromArgb(230, 234, 239), 190, 470);

            btnLimpiar.ForeColor = azul;

            Button btnEditar = CrearBoton(
                "EDITAR", azul, 20, 516);

            Button btnEliminar = CrearBoton(
                "ELIMINAR", Color.FromArgb(192, 57, 57), 190, 516);

            btnGuardar.Click += (s, e) => MostrarPendiente();
            btnEditar.Click += (s, e) => MostrarPendiente();
            btnEliminar.Click += (s, e) => MostrarPendiente();
            btnLimpiar.Click += (s, e) => LimpiarCampos();

            panelDatos.Controls.Add(btnGuardar);
            panelDatos.Controls.Add(btnLimpiar);
            panelDatos.Controls.Add(btnEditar);
            panelDatos.Controls.Add(btnEliminar);

            // PANEL DE LISTADO
            Panel panelListado = new Panel();
            panelListado.Dock = DockStyle.Fill;
            panelListado.BackColor = Color.White;
            panelListado.BorderStyle = BorderStyle.FixedSingle;
            panelListado.Margin = new Padding(0);

            // ENCABEZADO DEL LISTADO
            Panel panelSuperior = new Panel();
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Height = 115;
            panelSuperior.BackColor = Color.White;

            Label tituloListado = CrearEtiqueta(
                "Socios registrados", 20, 15, 400);

            tituloListado.Font = new Font(
                "Segoe UI", 15F, FontStyle.Bold);

            Label descripcionListado = CrearEtiqueta(
                "Consulta y administra la información de los socios.",
                20, 45, 500);

            descripcionListado.ForeColor = gris;

            txtBuscar = CrearCampo(20, 75, 340);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Button btnBuscar = CrearBoton(
                "BUSCAR", azul, 375, 73);

            btnBuscar.Width = 115;
            btnBuscar.Click += (s, e) => MostrarPendiente();

            panelSuperior.Controls.Add(tituloListado);
            panelSuperior.Controls.Add(descripcionListado);
            panelSuperior.Controls.Add(txtBuscar);
            panelSuperior.Controls.Add(btnBuscar);

            // TABLA DE SOCIOS
            dgvSocios = new DataGridView();

            dgvSocios.Dock = DockStyle.Fill;
            dgvSocios.BackgroundColor = Color.White;
            dgvSocios.BorderStyle = BorderStyle.None;
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ReadOnly = true;
            dgvSocios.MultiSelect = false;
            dgvSocios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSocios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSocios.RowHeadersVisible = false;
            dgvSocios.EnableHeadersVisualStyles = false;
            dgvSocios.ColumnHeadersHeight = 40;
            dgvSocios.RowTemplate.Height = 35;
            dgvSocios.GridColor = Color.FromArgb(230, 234, 239);

            dgvSocios.ColumnHeadersDefaultCellStyle.BackColor = azul;
            dgvSocios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSocios.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvSocios.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvSocios.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 239, 231);

            dgvSocios.DefaultCellStyle.SelectionForeColor = azul;

            dgvSocios.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvSocios.Columns.Add("Codigo", "Código");
            dgvSocios.Columns.Add("Nombre", "Nombre completo");
            dgvSocios.Columns.Add("CI", "CI");
            dgvSocios.Columns.Add("Direccion", "Dirección");
            dgvSocios.Columns.Add("Telefono", "Teléfono");
            dgvSocios.Columns.Add("Ingreso", "Ingreso mensual");

            // PIE DEL LISTADO
            Panel panelPie = new Panel();
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Height = 35;
            panelPie.BackColor = Color.White;

            Label estado = CrearEtiqueta(
                "Socios registrados: 0", 20, 8, 300);

            estado.ForeColor = gris;

            panelPie.Controls.Add(estado);

            panelListado.Controls.Add(dgvSocios);
            panelListado.Controls.Add(panelPie);
            panelListado.Controls.Add(panelSuperior);

            // AGREGAR PANELES
            contenido.Controls.Add(panelDatos, 0, 0);
            contenido.Controls.Add(panelListado, 1, 0);

            this.Controls.Add(contenido);
            this.Controls.Add(encabezado);

            this.ResumeLayout(true);
        }

        private Label CrearEtiqueta(
            string texto, int x, int y, int ancho)
        {
            return new Label
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, 22),
                ForeColor = azul,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
        }

        private TextBox CrearCampo(
            int x, int y, int ancho)
        {
            return new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(ancho, 32),
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top |
                         AnchorStyles.Left |
                         AnchorStyles.Right
            };
        }

        private Button CrearBoton(
            string texto, Color color, int x, int y)
        {
            Button boton = new Button();

            boton.Text = texto;
            boton.Location = new Point(x, y);
            boton.Size = new Size(155, 38);
            boton.BackColor = color;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font(
                "Segoe UI", 9F, FontStyle.Bold);

            boton.Cursor = Cursors.Hand;

            return boton;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCI.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtIngreso.Clear();
            txtBuscar.Clear();

            txtCodigo.Focus();
        }

        private void MostrarPendiente()
        {
            MessageBox.Show(
                "Esta operación se habilitará al conectar el módulo con SQL Server.",
                "Conexión pendiente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
