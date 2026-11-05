using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class CalculadoraPrestamo
    {
        private ICalculoPrestamo estrategia;

        public CalculadoraPrestamo(ICalculoPrestamo estrategia)
        {
            this.estrategia = estrategia;
        }

        public void CambiarEstrategia(ICalculoPrestamo nuevaEstrategia)
        {
            estrategia = nuevaEstrategia;
        }

        public decimal Calcular(
            decimal monto,
            decimal tasaAnual,
            int plazoMeses)
        {
            return estrategia.CalcularCuota(
                monto,
                tasaAnual,
                plazoMeses
            );
        }
    }
}
