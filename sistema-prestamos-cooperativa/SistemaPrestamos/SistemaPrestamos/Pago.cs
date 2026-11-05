using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public string MetodoPago { get; set; }
        public string Observacion { get; set; }

        public Pago()
        {
            MetodoPago = "";
            Observacion = "";
        }
    }
}
