
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaPrestamosCooperativa
{
    public partial class FrmPrincipal : Form
    {
        private Color azul = Color.FromArgb(31, 58, 95);
        private Color verde = Color.FromArgb(46, 158, 107);
        private Color fondo = Color.FromArgb(244, 246, 249);
        private Color blanco = Color.White;
        private Color gris = Color.FromArgb(100, 110, 125);

        public FrmPrincipal()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            this.Controls.Clear();

            this.Text = "Sistema de Préstamos - Cooperativa";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1050, 650);
            this.BackColor = fondo;
            this.Font = new Font("Segoe UI", 10F);

            // MENU PRINCIPAL
            MenuStrip menu = new MenuStrip();
            menu.BackColor = blanco;
            menu.ForeColor = azul;
            menu.Font = new Font("Segoe UI", 10F);
            menu.RenderMode = ToolStripRenderMode.System;

            ToolStripMenuItem archivo = new ToolStripMenuItem("Archivo");
            ToolStripMenuItem cerrarSesion =
                new ToolStripMenuItem("Cerrar sesión");
            ToolStripMenuItem salir = new ToolStripMenuItem("Salir");

            cerrarSesion.Click += CerrarSesion_Click;
            salir.Click += (s, e) => Application.Exit();

            archivo.DropDownItems.Add(cerrarSesion);
            archivo.DropDownItems.Add(salir);

            ToolStripMenuItem modulos =
                new ToolStripMenuItem("Módulos");

            ToolStripMenuItem socios =
                new ToolStripMenuItem("Gestión de socios");

            ToolStripMenuItem solicitudes =
                new ToolStripMenuItem("Solicitudes de préstamo");

            socios.Click += (s, e) =>
                AbrirFormulario("FrmSocios");

            solicitudes.Click += (s, e) =>
                AbrirFormulario("FrmSolicitudPrestamo");

            modulos.DropDownItems.Add(socios);
            modulos.DropDownItems.Add(solicitudes);

            ToolStripMenuItem ayuda = new ToolStripMenuItem("Ayuda");
            ToolStripMenuItem acerca = new ToolStripMenuItem("Acerca del sistema");

            acerca.Click += (s, e) =>
                MessageBox.Show(
                    "Sistema de Préstamos de Cooperativa\nVersión 1.0",
                    "Acerca del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            ayuda.DropDownItems.Add(acerca);

            menu.Items.Add(archivo);
            menu.Items.Add(modulos);
            menu.Items.Add(ayuda);

            this.MainMenuStrip = menu;

            // PANEL CENTRAL
            Panel contenido = new Panel();
            contenido.Dock = DockStyle.Fill;
            contenido.BackColor = fondo;
            contenido.AutoScroll = true;

            // PANEL LATERAL
            Panel lateral = new Panel();
            lateral.Dock = DockStyle.Left;
            lateral.Width = 245;
            lateral.BackColor = azul;

            // AGREGAR PANELES
            this.Controls.Add(contenido);
            this.Controls.Add(lateral);
            this.Controls.Add(menu);

            // IDENTIDAD DE LA COOPERATIVA
            Label logo = new Label();
            logo.Text = "SC";
            logo.Location = new Point(80, 35);
            logo.Size = new Size(85, 85);
            logo.BackColor = verde;
            logo.ForeColor = blanco;
            logo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            logo.TextAlign = ContentAlignment.MiddleCenter;

            lateral.Controls.Add(logo);

            Label nombre = new Label();
            nombre.Text = "COOPERATIVA\nDE AHORRO Y CRÉDITO";
            nombre.Location = new Point(15, 135);
            nombre.Size = new Size(215, 65);
            nombre.ForeColor = blanco;
            nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nombre.TextAlign = ContentAlignment.MiddleCenter;

            lateral.Controls.Add(nombre);

            Label menuTitulo = new Label();
            menuTitulo.Text = "NAVEGACIÓN";
            menuTitulo.Location = new Point(25, 225);
            menuTitulo.Size = new Size(190, 25);
            menuTitulo.ForeColor = Color.FromArgb(190, 205, 225);
            menuTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            lateral.Controls.Add(menuTitulo);

            // BOTONES LATERALES
            Button btnInicio = CrearBotonLateral("Inicio", 265);
            btnInicio.Click += (s, e) =>
                MessageBox.Show("Estás en el panel principal.");

            lateral.Controls.Add(btnInicio);

            Button btnSocios = CrearBotonLateral("Gestión de socios", 320);
            btnSocios.Click += (s, e) =>
                AbrirFormulario("FrmSocios");

            lateral.Controls.Add(btnSocios);

            Button btnSolicitudes =
                CrearBotonLateral("Solicitudes de préstamo", 375);

            btnSolicitudes.Click += (s, e) =>
                AbrirFormulario("FrmSolicitudPrestamo");

            lateral.Controls.Add(btnSolicitudes);

            // BOTON CERRAR SESION
            Button btnCerrar = CrearBotonLateral("Cerrar sesión", 0);
            btnCerrar.Dock = DockStyle.Bottom;
            btnCerrar.Height = 48;
            btnCerrar.Click += CerrarSesion_Click;

            lateral.Controls.Add(btnCerrar);

            // ENCABEZADO CENTRAL
            Panel encabezado = new Panel();
            encabezado.Dock = DockStyle.Top;
            encabezado.Height = 125;
            encabezado.BackColor = fondo;

            Label titulo = new Label();
            titulo.Text = "Panel de administración";
            titulo.Location = new Point(35, 25);
            titulo.Size = new Size(650, 45);
            titulo.ForeColor = azul;
            titulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);

            encabezado.Controls.Add(titulo);

            Label subtitulo = new Label();
            subtitulo.Text =
                "Bienvenido al sistema de gestión de préstamos.";
            subtitulo.Location = new Point(38, 76);
            subtitulo.Size = new Size(650, 25);
            subtitulo.ForeColor = gris;
            subtitulo.Font = new Font("Segoe UI", 10F);

            encabezado.Controls.Add(subtitulo);

            // TARJETA DE SOCIOS
            Panel tarjetaSocios = CrearTarjeta(
                "Gestión de socios",
                "Registro, edición y búsqueda\nde los socios de la cooperativa.",
                35,
                "ABRIR MÓDULO",
                "FrmSocios");

            contenido.Controls.Add(tarjetaSocios);

            // TARJETA DE SOLICITUDES
            Panel tarjetaSolicitudes = CrearTarjeta(
                "Solicitudes de préstamo",
                "Acceso a la gestión de solicitudes\nde préstamos.",
                325,
                "ABRIR MÓDULO",
                "FrmSolicitudPrestamo");

            contenido.Controls.Add(tarjetaSolicitudes);

            // AGREGAR ENCABEZADO AL FINAL
            contenido.Controls.Add(encabezado);
            encabezado.BringToFront();
        }

        private Button CrearBotonLateral(string texto, int posicionY)
        {
            Button boton = new Button();

            boton.Text = "   " + texto;
            boton.Location = new Point(18, posicionY);
            boton.Size = new Size(210, 45);
            boton.BackColor = azul;
            boton.ForeColor = blanco;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(45, 75, 115);
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.Cursor = Cursors.Hand;

            return boton;
        }

        private Panel CrearTarjeta(
            string titulo,
            string descripcion,
            int posicionX,
            string textoBoton,
            string nombreFormulario)
        {
            Panel tarjeta = new Panel();

            tarjeta.Location = new Point(posicionX, 155);
            tarjeta.Size = new Size(265, 200);
            tarjeta.BackColor = blanco;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;

            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Location = new Point(18, 20);
            lblTitulo.Size = new Size(225, 35);
            lblTitulo.ForeColor = azul;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);

            tarjeta.Controls.Add(lblTitulo);

            Label lblDescripcion = new Label();
            lblDescripcion.Text = descripcion;
            lblDescripcion.Location = new Point(18, 65);
            lblDescripcion.Size = new Size(225, 55);
            lblDescripcion.ForeColor = gris;
            lblDescripcion.Font = new Font("Segoe UI", 9F);

            tarjeta.Controls.Add(lblDescripcion);

            Button boton = new Button();
            boton.Text = textoBoton;
            boton.Location = new Point(18, 135);
            boton.Size = new Size(225, 42);
            boton.BackColor = verde;
            boton.ForeColor = blanco;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;

            boton.Click += (s, e) =>
                AbrirFormulario(nombreFormulario);

            tarjeta.Controls.Add(boton);

            return tarjeta;
        }

        // APERTURA DE FORMULARIOS DEL PROYECTO
        private void AbrirFormulario(string nombreFormulario)
        {
            string nombreCompleto =
                "SistemaPrestamosCooperativa." + nombreFormulario;

            Type tipo = typeof(FrmPrincipal).Assembly.GetType(nombreCompleto);

            if (tipo == null || !typeof(Form).IsAssignableFrom(tipo))
            {
                MessageBox.Show(
                    "El formulario " + nombreFormulario +
                    " todavía no está incorporado al proyecto.\n\n" +
                    "Se podrá abrir cuando se integre el trabajo correspondiente.",
                    "Formulario pendiente de integración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            foreach (Form abierto in Application.OpenForms)
            {
                if (abierto.GetType() == tipo)
                {
                    if (abierto.WindowState == FormWindowState.Minimized)
                        abierto.WindowState = FormWindowState.Normal;

                    abierto.Activate();
                    return;
                }
            }

            try
            {
                Form nuevo = (Form)Activator.CreateInstance(tipo);
                nuevo.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo abrir el formulario.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // CERRAR SESION Y VOLVER AL LOGIN
        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = null;

            foreach (Form abierto in Application.OpenForms)
            {
                if (abierto is FrmLogin)
                {
                    login = (FrmLogin)abierto;
                    break;
                }
            }

            if (login == null)
                login = new FrmLogin();

            login.Show();
            login.Activate();

            this.Close();
        }
    }
}
