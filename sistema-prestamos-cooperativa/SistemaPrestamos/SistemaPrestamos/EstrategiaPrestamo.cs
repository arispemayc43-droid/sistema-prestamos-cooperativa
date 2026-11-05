using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{

    public class EstrategiaCuotaFija : ICalculoPrestamo
    {
        public decimal CalcularCuota(
            decimal monto,
            decimal tasaAnual,
            int plazoMeses)
        {
            if (monto <= 0 || plazoMeses <= 0)
            {
                return 0;
            }

            decimal tasaMensual = tasaAnual / 100 / 12;

            if (tasaMensual == 0)
            {
                return Math.Round(
                    monto / plazoMeses, 2
                );
            }

            double tasa = (double)tasaMensual;

            double cuota = (double)monto *
                tasa /
                (1 - Math.Pow(1 + tasa, -plazoMeses));

            return Math.Round((decimal)cuota, 2);
        }
    }
}
