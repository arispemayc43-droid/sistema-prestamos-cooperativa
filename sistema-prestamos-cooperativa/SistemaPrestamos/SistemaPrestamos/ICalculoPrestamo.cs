using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public interface ICalculoPrestamo
    {
        decimal CalcularCuota(
            decimal monto,
            decimal tasaAnual,
            int plazoMeses
        );
    }
}
