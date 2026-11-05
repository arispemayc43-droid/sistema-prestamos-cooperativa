using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdSocio { get; set; }
        public string NombreSocio { get; set; }
        public string TipoPrestamo { get; set; }
        public decimal Monto { get; set; }
        public decimal TasaInteres { get; set; }
        public int PlazoMeses { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDesembolso { get; set; }
        public string Estado { get; set; }
        public decimal SaldoPendiente { get; set; }

        public Prestamo()
        {
            NombreSocio = "";
            TipoPrestamo = "";
            Estado = "";
        }
    }
}
