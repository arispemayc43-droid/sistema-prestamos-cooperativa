using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class PagoService
    {
        private List<Pago> pagos;

        public PagoService()
        {
            pagos = new List<Pago>();
        }

        public List<Pago> ListarPagos()
        {
            return pagos;
        }

        public void RegistrarPago(Pago pago)
        {
            if (pago == null)
                throw new ArgumentNullException(nameof(pago));

            if (pago.MontoPagado <= 0)
                throw new ArgumentException(
                    "El monto del pago debe ser mayor a cero.");

            pago.IdPago = pagos.Count + 1;
            pago.FechaPago = DateTime.Now;

            pagos.Add(pago);
        }

        public List<Pago> BuscarPagosPorPrestamo(int idPrestamo)
        {
            return pagos
                .Where(p => p.IdPrestamo == idPrestamo)
                .ToList();
        }

        public decimal CalcularTotalPagado(int idPrestamo)
        {
            return pagos
                .Where(p => p.IdPrestamo == idPrestamo)
                .Sum(p => p.MontoPagado);
        }
    }
}
