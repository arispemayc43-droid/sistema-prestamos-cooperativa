
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmCronogramaPagos : Form
    {
        private CuotaService cuotaService;
        private Prestamo prestamoSeleccionado;
        private List<Cuota> listaCuotas;

        public FrmCronogramaPagos()
        {
            InitializeComponent();

            cuotaService = new CuotaService();
            listaCuotas = new List<Cuota>();

            btnActualizar.Click += btnActualizar_Click;
            btnVolver.Click += btnVolver_Click;

            this.Load += FrmCronogramaPagos_Load;
        }

        public FrmCronogramaPagos(Prestamo prestamo)
            : this()
        {
            prestamoSeleccionado = prestamo;
        }

        private void FrmCronogramaPagos_Load(object sender, EventArgs e)
        {
            if (prestamoSeleccionado != null)
            {
                MostrarInformacionPrestamo();
                CargarCronograma();
            }
            else
            {
                MessageBox.Show(
                    "No se ha seleccionado ningún préstamo.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void MostrarInformacionPrestamo()
        {
            lblValorPrestamo.Text =
                prestamoSeleccionado.IdPrestamo.ToString();

            lblValorSocio.Text =
                prestamoSeleccionado.NombreSocio;

            lblValorMonto.Text =
                "Bs. " + prestamoSeleccionado.Monto.ToString("N2");

            lblValorPlazo.Text =
                prestamoSeleccionado.PlazoMeses + " meses";
        }

        private void CargarCronograma()
        {
            try
            {
                if (prestamoSeleccionado == null)
                    return;

                listaCuotas = cuotaService.ListarCuotas(
                    prestamoSeleccionado.IdPrestamo);

                if (listaCuotas.Count == 0)
                {
                    cuotaService.GenerarCronograma(
                        prestamoSeleccionado);

                    listaCuotas = cuotaService.ListarCuotas(
                        prestamoSeleccionado.IdPrestamo);
                }

                MostrarCuotas();
                ActualizarResumen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el cronograma.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarCuotas()
        {
            dgvCronograma.Rows.Clear();

            foreach (Cuota cuota in listaCuotas)
            {
                dgvCronograma.Rows.Add(
                    cuota.NumeroCuota,
                    cuota.FechaVencimiento.ToShortDateString(),
                    cuota.Capital.ToString("N2"),
                    cuota.Interes.ToString("N2"),
                    cuota.Importe.ToString("N2"),
                    cuota.SaldoPendiente.ToString("N2"),
                    cuota.Estado
                );
            }
        }

        private void ActualizarResumen()
        {
            int total = listaCuotas.Count;
            int pagadas = 0;
            int pendientes = 0;

            foreach (Cuota cuota in listaCuotas)
            {
                if (cuota.Estado == "Pagada")
                {
                    pagadas++;
                }
                else
                {
                    pendientes++;
                }
            }

            lblTotalCuotas.Text =
                "TOTAL CUOTAS: " + total;

            lblPagadas.Text =
                "PAGADAS: " + pagadas;

            lblPendientes.Text =
                "PENDIENTES: " + pendientes;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCronograma();

            MessageBox.Show(
                "Cronograma actualizado.",
                "Actualización",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

