
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmPagos : Form
    {
        private PagoService pagoService;
        private PrestamoService prestamoService;
        private List<Prestamo> listaPrestamos;

        public FrmPagos()
        {
            InitializeComponent();

            pagoService = new PagoService();
            prestamoService = new PrestamoService();
            listaPrestamos = new List<Prestamo>();

            btnRegistrar.Click += btnRegistrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnCancelar.Click += btnCancelar_Click;

            cmbPrestamo.SelectedIndexChanged += cmbPrestamo_SelectedIndexChanged;
            cmbPrestamo.Format += cmbPrestamo_Format;

            this.Load += FrmPagos_Load;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            dtpFechaPago.Value = DateTime.Today;
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            try
            {
                listaPrestamos = prestamoService.ListarPrestamos();

                cmbPrestamo.DataSource = null;
                cmbPrestamo.DataSource = listaPrestamos;

                cmbPrestamo.DisplayMember = "NombreSocio";
                cmbPrestamo.ValueMember = "IdPrestamo";

                if (listaPrestamos.Count > 0)
                {
                    cmbPrestamo.SelectedIndex = 0;
                    ActualizarSaldo();
                }
                else
                {
                    lblSaldo.Text = "Saldo pendiente: Bs. 0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los préstamos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void cmbPrestamo_Format(object sender, ListControlConvertEventArgs e)
        {
            Prestamo prestamo = e.ListItem as Prestamo;

            if (prestamo != null)
            {
                e.Value = "Préstamo #" + prestamo.IdPrestamo +
                          " - " + prestamo.NombreSocio;
            }
        }

        private void cmbPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarSaldo();
        }

        private void ActualizarSaldo()
        {
            Prestamo prestamo = cmbPrestamo.SelectedItem as Prestamo;

            if (prestamo != null)
            {
                lblSaldo.Text = "Saldo pendiente: Bs. " +
                    prestamo.SaldoPendiente.ToString("N2");
            }
            else
            {
                lblSaldo.Text = "Saldo pendiente: Bs. 0.00";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = cmbPrestamo.SelectedItem as Prestamo;

            if (prestamo == null)
            {
                MessageBox.Show("Seleccione un préstamo.");
                return;
            }

            decimal monto;

            if (!decimal.TryParse(
                txtMonto.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out monto) || monto <= 0)
            {
                MessageBox.Show(
                    "Ingrese un monto válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMonto.Focus();
                return;
            }

            if (monto > prestamo.SaldoPendiente)
            {
                MessageBox.Show(
                    "El monto supera el saldo pendiente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbMetodo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            Pago pago = new Pago();

            pago.IdPrestamo = prestamo.IdPrestamo;
            pago.FechaPago = dtpFechaPago.Value;
            pago.MontoPagado = monto;
            pago.MetodoPago = cmbMetodo.Text;
            pago.Observacion = txtObservacion.Text.Trim();

            try
            {
                pagoService.RegistrarPago(pago);

                MessageBox.Show(
                    "¡Pago registrado correctamente!",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                int idPrestamo = prestamo.IdPrestamo;

                CargarPrestamos();

                cmbPrestamo.SelectedValue = idPrestamo;

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el pago.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtMonto.Clear();
            txtObservacion.Clear();

            dtpFechaPago.Value = DateTime.Today;

            cmbMetodo.SelectedIndex = 0;

            if (cmbPrestamo.Items.Count > 0)
            {
                cmbPrestamo.SelectedIndex = 0;
            }

            ActualizarSaldo();

            txtMonto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
