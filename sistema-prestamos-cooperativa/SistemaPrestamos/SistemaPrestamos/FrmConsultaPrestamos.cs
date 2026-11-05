
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FrmConsultaPrestamos : Form
    {
        private PrestamoService prestamoService;
        private List<Prestamo> listaPrestamos;

        public FrmConsultaPrestamos()
        {
            InitializeComponent();

            prestamoService = new PrestamoService();
            listaPrestamos = new List<Prestamo>();

            
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;

            this.Load += FrmConsultaPrestamos_Load;
        }
        private void FrmConsultaPrestamos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            try
            {
                listaPrestamos = prestamoService.ListarPrestamos();

                MostrarPrestamos(listaPrestamos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los préstamos.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarPrestamos(List<Prestamo> prestamos)
        {
            dgvPrestamos.Rows.Clear();

            foreach (Prestamo prestamo in prestamos)
            {
                dgvPrestamos.Rows.Add(
                    prestamo.IdPrestamo,
                    prestamo.NombreSocio,
                    prestamo.TipoPrestamo,
                    prestamo.Monto,
                    prestamo.PlazoMeses,
                    prestamo.SaldoPendiente,
                    prestamo.Estado
                );
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscarSocio.Text.Trim().ToLower();

            string tipo = cmbTipoPrestamo.Text;
            string estado = cmbEstado.Text;

            List<Prestamo> resultados = new List<Prestamo>();

            foreach (Prestamo prestamo in listaPrestamos)
            {
                bool coincideSocio =
                    string.IsNullOrEmpty(buscar) ||
                    (prestamo.NombreSocio != null &&
                    prestamo.NombreSocio.ToLower().Contains(buscar));

                bool coincideTipo =
                    tipo == "Todos" ||
                    prestamo.TipoPrestamo == tipo;

                bool coincideEstado =
                    estado == "Todos" ||
                    prestamo.Estado == estado;

                if (coincideSocio && coincideTipo && coincideEstado)
                {
                    resultados.Add(prestamo);
                }
            }

            MostrarPrestamos(resultados);

            if (resultados.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron préstamos.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarSocio.Clear();

            cmbTipoPrestamo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            MostrarPrestamos(listaPrestamos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
