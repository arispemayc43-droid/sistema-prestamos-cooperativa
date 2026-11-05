using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPrestamos.Estrategias;

namespace SistemaPrestamos
{
    public partial class Form1 : Form
    {
        private IPrestamoStrategy estrategia;   // la estrategia elegida (patrón Strategy)
        private DataTable tabla;
        private decimal ingresoSocio;
        private bool socioCargado;
        public Form1()
        {
            InitializeComponent();
            dgvSolicitudes.CellFormatting += dgvSolicitudes_CellFormatting;
        }
        private void FrmSolicitudPrestamo_Load(object sender, EventArgs e)
        {
            // Tipos de préstamo salen de las estrategias
            foreach (var est in PrestamoFactory.Todas())
                cboTipoPrestamo.Items.Add(est.Nombre);

            // Tabla en memoria (después se reemplaza por SQL Server)
            tabla = new DataTable();
            tabla.Columns.Add("Nro", typeof(int));
            tabla.Columns.Add("Código socio", typeof(string));
            tabla.Columns.Add("Socio", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Monto", typeof(decimal));
            tabla.Columns.Add("Plazo", typeof(int));
            tabla.Columns.Add("Tasa %", typeof(decimal));
            tabla.Columns.Add("Fecha", typeof(DateTime));
            tabla.Columns.Add("Estado", typeof(string));
            dgvSolicitudes.DataSource = tabla;

            dgvSolicitudes.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvSolicitudes.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSolicitudes.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            Limpiar();
        }
        private void btnBuscarSocio_Click(object sender, EventArgs e) 
        {
            string codigo = txtCodigoSocio.Text.Trim().ToUpper();
            if (codigo == "")
            {
                MessageBox.Show("Ingresa el código del socio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoSocio.Focus();
                return;
            }

            string nombre;
            decimal ingreso;
            if (!BuscarSocio(codigo, out nombre, out ingreso))
            {
                MessageBox.Show("No se encontró un socio con el código " + codigo + ".", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                socioCargado = false;
                txtNombreSocio.Clear();
                txtIngresoSocio.Clear();
                return;
            }

            txtNombreSocio.Text = nombre;
            txtIngresoSocio.Text = ingreso.ToString("N2");
            ingresoSocio = ingreso;
            socioCargado = true;
        }
        private bool BuscarSocio(string codigo, out string nombre, out decimal ingreso)
        {
            switch (codigo)
            {
                case "S001": nombre = "Juan Pérez Mamani"; ingreso = 4500m; return true;
                case "S002": nombre = "María Rojas Quispe"; ingreso = 8000m; return true;
                case "S003": nombre = "Carlos Flores Choque"; ingreso = 12000m; return true;
                default: nombre = ""; ingreso = 0; return false;
            }
        }
        private void cboTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (cboTipoPrestamo.SelectedItem == null) return;

            estrategia = PrestamoFactory.ObtenerEstrategia(cboTipoPrestamo.SelectedItem.ToString());

            txtTasa.Text = estrategia.TasaAnual.ToString("0.##") + " %";
            lblRangoMonto.Text = string.Format("Rango: Bs {0:N0} a Bs {1:N0}",
                estrategia.MontoMinimo, estrategia.MontoMaximo);
            lblRangoPlazo.Text = string.Format("Rango: {0} a {1} meses",
                estrategia.PlazoMinimo, estrategia.PlazoMaximo);
            lblRequisito.Text = "Requisito: " + estrategia.Requisito;

            cboGarantia.Items.Clear();
            cboGarantia.Items.AddRange(estrategia.GarantiasPermitidas);
            cboGarantia.SelectedIndex = 0;

            // Valores sugeridos (el usuario puede cambiarlos; se validan al guardar)
            nudMonto.Value = estrategia.MontoMinimo;
            nudPlazo.Value = estrategia.PlazoMinimo;
        }
        private void btnNuevo_Click(object sender, EventArgs e) 
        {

            Limpiar();
            txtCodigoSocio.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!socioCargado)
            {
                MessageBox.Show("Primero busca y selecciona un socio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoSocio.Focus();
                return;
            }

            if (estrategia == null)
            {
                MessageBox.Show("Selecciona el tipo de préstamo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipoPrestamo.Focus();
                return;
            }

            if (ingresoSocio <= 0)
            {
                MessageBox.Show("El socio debe demostrar ingresos mensuales.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto = nudMonto.Value;
            int plazo = (int)nudPlazo.Value;
            string garantia = cboGarantia.SelectedItem == null ? null : cboGarantia.SelectedItem.ToString();

            // La estrategia valida monto, plazo y garantía según el tipo
            string error = estrategia.ValidarSolicitud(monto, plazo, garantia);
            if (error != null)
            {
                MessageBox.Show(error, "Solicitud no válida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: reemplazar por INSERT en la tabla Solicitud (SQL Server)
            int nro = tabla.Rows.Count + 1;
            tabla.Rows.Add(nro, txtCodigoSocio.Text.Trim().ToUpper(), txtNombreSocio.Text,
                           estrategia.Nombre, monto, plazo, estrategia.TasaAnual,
                           dtpFecha.Value.Date, "Pendiente");

            MessageBox.Show("Solicitud N° " + nro + " registrada en estado Pendiente.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            Close();
        }
        private void btnDocumentos_Click(object sender, EventArgs e) 
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una solicitud de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nro = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Nro"].Value);

            // Cuando exista FrmDocumentosGarantias, quita el MessageBox y descomenta:
            // new FrmDocumentosGarantias(nro).ShowDialog();
            MessageBox.Show("Aquí se abrirá FrmDocumentosGarantias para la solicitud N° " + nro + ".");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (dgvSolicitudes.Columns[e.ColumnIndex].Name != "Estado") return;

            switch (e.Value.ToString())
            {
                case "Aprobada": e.CellStyle.BackColor = Color.FromArgb(46, 158, 107); break;
                case "Rechazada": e.CellStyle.BackColor = Color.FromArgb(192, 57, 43); break;
                case "En Evaluación": e.CellStyle.BackColor = Color.FromArgb(31, 58, 95); break;
                default: e.CellStyle.BackColor = Color.FromArgb(224, 165, 38); break; // Pendiente
            }
            e.CellStyle.ForeColor = Color.White;
            e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
            e.CellStyle.SelectionForeColor = Color.White;
        }
        private void Limpiar()
        {
            txtCodigoSocio.Clear();
            txtNombreSocio.Clear();
            txtIngresoSocio.Clear();
            ingresoSocio = 0;
            socioCargado = false;

            estrategia = null;
            cboTipoPrestamo.SelectedIndex = -1;
            cboGarantia.Items.Clear();
            txtTasa.Clear();
            txtEstado.Text = "Pendiente";
            dtpFecha.Value = DateTime.Today;
            nudMonto.Value = 0;
            nudPlazo.Value = 0;
            lblRangoMonto.Text = "Rango: -";
            lblRangoPlazo.Text = "Rango: -";
            lblRequisito.Text = "Requisito: -";
        }
    }
}
