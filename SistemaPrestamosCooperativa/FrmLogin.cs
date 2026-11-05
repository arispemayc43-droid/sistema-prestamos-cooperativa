
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaPrestamosCooperativa
{
    public partial class FrmLogin : Form
    {
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private CheckBox chkMostrar;

        public FrmLogin()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void ConstruirInterfaz()
        {
            this.SuspendLayout();

            // CONFIGURACION GENERAL
            this.Text = "Sistema de Préstamos - Cooperativa";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1000, 620);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Font = new Font("Segoe UI", 10F);
            this.DoubleBuffered = true;

            Color azul = Color.FromArgb(31, 58, 95);
            Color verde = Color.FromArgb(46, 158, 107);
            Color gris = Color.FromArgb(100, 110, 125);
            Color blanco = Color.White;

            // TARJETA PRINCIPAL
            Panel tarjeta = new Panel();
            tarjeta.Location = new Point(70, 55);
            tarjeta.Size = new Size(860, 510);
            tarjeta.BackColor = blanco;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(tarjeta);

            // PANEL IZQUIERDO
            Panel panelMarca = new Panel();
            panelMarca.Location = new Point(0, 0);
            panelMarca.Size = new Size(320, 510);
            panelMarca.BackColor = azul;

            tarjeta.Controls.Add(panelMarca);

            // LOGOTIPO
            Label lblLogo = new Label();
            lblLogo.Text = "SC";
            lblLogo.Location = new Point(115, 70);
            lblLogo.Size = new Size(90, 90);
            lblLogo.BackColor = verde;
            lblLogo.ForeColor = blanco;
            lblLogo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;

            using (GraphicsPath circulo = new GraphicsPath())
            {
                circulo.AddEllipse(0, 0, 90, 90);
                lblLogo.Region = new Region(circulo);
            }

            panelMarca.Controls.Add(lblLogo);


            // NOMBRE DE LA COOPERATIVA
            Label lblMarca = new Label();
            lblMarca.Text = "COOPERATIVA\nDE AHORRO Y\nCRÉDITO";
            lblMarca.Location = new Point(25, 180);
            lblMarca.Size = new Size(270, 105);
            lblMarca.ForeColor = blanco;
            lblMarca.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;

            panelMarca.Controls.Add(lblMarca);

            // DESCRIPCION
            Label lblDescripcion = new Label();
            lblDescripcion.Text = "Soluciones financieras\npara nuestros socios.";
            lblDescripcion.Location = new Point(35, 300);
            lblDescripcion.Size = new Size(250, 60);
            lblDescripcion.ForeColor = Color.FromArgb(220, 230, 240);
            lblDescripcion.Font = new Font("Segoe UI", 11F);
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;

            panelMarca.Controls.Add(lblDescripcion);

            // LINEA VERDE
            Panel linea = new Panel();
            linea.Location = new Point(105, 385);
            linea.Size = new Size(110, 4);
            linea.BackColor = verde;

            panelMarca.Controls.Add(linea);

            // FRASE INFERIOR
            Label lblFrase = new Label();
            lblFrase.Text = "SEGURIDAD  |  CONFIANZA  |  CRECIMIENTO";
            lblFrase.Location = new Point(15, 420);
            lblFrase.Size = new Size(290, 35);
            lblFrase.ForeColor = Color.FromArgb(210, 220, 235);
            lblFrase.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFrase.TextAlign = ContentAlignment.MiddleCenter;

            panelMarca.Controls.Add(lblFrase);

            // PANEL DERECHO
            Panel panelAcceso = new Panel();
            panelAcceso.Location = new Point(320, 0);
            panelAcceso.Size = new Size(540, 510);
            panelAcceso.BackColor = blanco;

            tarjeta.Controls.Add(panelAcceso);

            // TITULO
            Label lblTitulo = new Label();
            lblTitulo.Text = "Bienvenido";
            lblTitulo.Location = new Point(55, 70);
            lblTitulo.Size = new Size(430, 42);
            lblTitulo.ForeColor = azul;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);

            panelAcceso.Controls.Add(lblTitulo);

            // SUBTITULO
            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "Ingresa tus credenciales para continuar.";
            lblSubtitulo.Location = new Point(55, 118);
            lblSubtitulo.Size = new Size(430, 25);
            lblSubtitulo.ForeColor = gris;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);

            panelAcceso.Controls.Add(lblSubtitulo);

            // ETIQUETA USUARIO
            Label lblUsuario = new Label();
            lblUsuario.Text = "USUARIO";
            lblUsuario.Location = new Point(55, 172);
            lblUsuario.Size = new Size(430, 20);
            lblUsuario.ForeColor = azul;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            panelAcceso.Controls.Add(lblUsuario);

            // CAJA USUARIO
            Panel cajaUsuario = new Panel();
            cajaUsuario.Location = new Point(55, 196);
            cajaUsuario.Size = new Size(430, 48);
            cajaUsuario.BackColor = blanco;
            cajaUsuario.BorderStyle = BorderStyle.FixedSingle;

            panelAcceso.Controls.Add(cajaUsuario);

            txtUsuario = new TextBox();
            txtUsuario.Location = new Point(12, 12);
            txtUsuario.Size = new Size(400, 25);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.TabIndex = 0;

            cajaUsuario.Controls.Add(txtUsuario);

            // ETIQUETA CONTRASENA
            Label lblContrasena = new Label();
            lblContrasena.Text = "CONTRASEÑA";
            lblContrasena.Location = new Point(55, 264);
            lblContrasena.Size = new Size(430, 20);
            lblContrasena.ForeColor = azul;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            panelAcceso.Controls.Add(lblContrasena);

            // CAJA CONTRASENA
            Panel cajaContrasena = new Panel();
            cajaContrasena.Location = new Point(55, 288);
            cajaContrasena.Size = new Size(430, 48);
            cajaContrasena.BackColor = blanco;
            cajaContrasena.BorderStyle = BorderStyle.FixedSingle;

            panelAcceso.Controls.Add(cajaContrasena);

            txtContrasena = new TextBox();
            txtContrasena.Location = new Point(12, 12);
            txtContrasena.Size = new Size(400, 25);
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Segoe UI", 11F);
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TabIndex = 1;

            cajaContrasena.Controls.Add(txtContrasena);

            // MOSTRAR CONTRASENA
            chkMostrar = new CheckBox();
            chkMostrar.Text = "Mostrar contraseña";
            chkMostrar.Location = new Point(55, 348);
            chkMostrar.AutoSize = true;
            chkMostrar.ForeColor = gris;
            chkMostrar.Font = new Font("Segoe UI", 9F);
            chkMostrar.TabIndex = 2;

            chkMostrar.CheckedChanged += (sender, e) =>
            {
                txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
            };

            panelAcceso.Controls.Add(chkMostrar);

            // BOTON INGRESAR
            Button btnIngresar = new Button();
            btnIngresar.Text = "INICIAR SESIÓN";
            btnIngresar.Location = new Point(55, 390);
            btnIngresar.Size = new Size(430, 48);
            btnIngresar.BackColor = verde;
            btnIngresar.ForeColor = blanco;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(39, 135, 92);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.TabIndex = 3;

            using (GraphicsPath ruta = new GraphicsPath())
            {
                int radio = 12;

                ruta.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
                ruta.AddArc(430 - radio * 2, 0,
                    radio * 2, radio * 2, 270, 90);
                ruta.AddArc(430 - radio * 2, 48 - radio * 2,
                    radio * 2, radio * 2, 0, 90);
                ruta.AddArc(0, 48 - radio * 2,
                    radio * 2, radio * 2, 90, 90);

                ruta.CloseFigure();
                btnIngresar.Region = new Region(ruta);
            }

            btnIngresar.Click += BtnIngresar_Click;

            panelAcceso.Controls.Add(btnIngresar);

            // PIE DE FORMULARIO
            Label lblPie = new Label();
            lblPie.Text = "Sistema de gestión de préstamos | 2026";
            lblPie.Location = new Point(55, 455);
            lblPie.Size = new Size(430, 25);
            lblPie.ForeColor = gris;
            lblPie.Font = new Font("Segoe UI", 8F);
            lblPie.TextAlign = ContentAlignment.MiddleCenter;

            panelAcceso.Controls.Add(lblPie);

            this.AcceptButton = btnIngresar;
            this.ActiveControl = txtUsuario;

            this.ResumeLayout(false);
        }

        // VALIDACION INICIAL DE CAMPOS
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show(
                    "Ingresa tu nombre de usuario.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingresa tu contraseña.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContrasena.Focus();
                return;
            }

            if (usuario == "admin" && contrasena == "Coop2026")
            {
                FrmPrincipal principal = new FrmPrincipal();

                principal.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show(
                    "El usuario o la contraseña son incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtContrasena.Clear();
                txtUsuario.Focus();
            }
        }
    }
}