using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    public class CuotaService
    {
        private List<Cuota> cuotas;
        private CalculadoraPrestamo calculadora;

        public CuotaService()
        {
            cuotas = new List<Cuota>();
            calculadora = new CalculadoraPrestamo(
                new EstrategiaCuotaFija());
        }

        public List<Cuota> ListarCuotas(int idPrestamo)
        {
            return cuotas.FindAll(
                c => c.IdPrestamo == idPrestamo);
        }

        public void GenerarCronograma(Prestamo prestamo)
        {
            if (prestamo == null)
                throw new ArgumentNullException(nameof(prestamo));

            if (prestamo.PlazoMeses <= 0 ||
                prestamo.Monto <= 0)
                throw new ArgumentException(
                    "Los datos del préstamo no son válidos.");

            cuotas.RemoveAll(
                c => c.IdPrestamo == prestamo.IdPrestamo);

            decimal cuotaMensual = calculadora.Calcular(
                prestamo.Monto,
                prestamo.TasaInteres,
                prestamo.PlazoMeses);

            decimal saldo = prestamo.Monto;

            for (int i = 1; i <= prestamo.PlazoMeses; i++)
            {
                decimal interes = Math.Round(
                    saldo * prestamo.TasaInteres / 100 / 12, 2);

                decimal capital = Math.Min(
                    saldo, cuotaMensual - interes);

                if (i == prestamo.PlazoMeses)
                    capital = saldo;

                decimal importe = capital + interes;

                saldo = Math.Max(0, saldo - capital);

                Cuota cuota = new Cuota
                {
                    IdCuota = cuotas.Count + 1,
                    IdPrestamo = prestamo.IdPrestamo,
                    NumeroCuota = i,
                    FechaVencimiento =
                        DateTime.Today.AddMonths(i),
                    Capital = capital,
                    Interes = interes,
                    Importe = importe,
                    SaldoPendiente = saldo,
                    Estado = "Pendiente"
                };

                cuotas.Add(cuota);
            }
        }
    }
}