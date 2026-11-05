using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public int IdPrestamo { get; set; }
        public int NumeroCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Importe { get; set; }
        public decimal SaldoPendiente { get; set; }
        public string Estado { get; set; }

        public Cuota()
        {
            Estado = "Pendiente";
        }
    }
}
