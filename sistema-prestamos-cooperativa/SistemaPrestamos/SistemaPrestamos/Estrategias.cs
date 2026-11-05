using System;
using System.Linq;

namespace SistemaPrestamos.Estrategias
{
    // ===== Strategy (interfaz) =====
    public interface IPrestamoStrategy
    {
        string Nombre { get; }
        decimal MontoMinimo { get; }
        decimal MontoMaximo { get; }
        int PlazoMinimo { get; }
        int PlazoMaximo { get; }
        decimal TasaAnual { get; }
        string Requisito { get; }
        string[] GarantiasPermitidas { get; }
        string ValidarSolicitud(decimal monto, int plazo, string garantia);
    }

    // ===== Clase base con la validación común =====
    public abstract class PrestamoBase : IPrestamoStrategy
    {
        public abstract string Nombre { get; }
        public abstract decimal MontoMinimo { get; }
        public abstract decimal MontoMaximo { get; }
        public abstract int PlazoMinimo { get; }
        public abstract int PlazoMaximo { get; }
        public abstract decimal TasaAnual { get; }
        public abstract string Requisito { get; }
        public abstract string[] GarantiasPermitidas { get; }

        // Devuelve null si la solicitud es válida; si no, el mensaje de error
        public string ValidarSolicitud(decimal monto, int plazo, string garantia)
        {
            if (monto < MontoMinimo || monto > MontoMaximo)
                return string.Format("El monto debe estar entre Bs {0:N0} y Bs {1:N0} para el préstamo {2}.",
                                     MontoMinimo, MontoMaximo, Nombre.ToLower());

            if (plazo < PlazoMinimo || plazo > PlazoMaximo)
                return string.Format("El plazo debe estar entre {0} y {1} meses para el préstamo {2}.",
                                     PlazoMinimo, PlazoMaximo, Nombre.ToLower());

            if (string.IsNullOrEmpty(garantia) || !GarantiasPermitidas.Contains(garantia))
                return string.Format("La garantía para el préstamo {0} debe ser: {1}.",
                                     Nombre.ToLower(), string.Join(" o ", GarantiasPermitidas).ToLower());

            return null;
        }
    }

    // ===== Estrategias concretas =====
    public class PrestamoConsumo : PrestamoBase
    {
        public override string Nombre { get { return "Consumo"; } }
        public override decimal MontoMinimo { get { return 5000m; } }
        public override decimal MontoMaximo { get { return 50000m; } }
        public override int PlazoMinimo { get { return 6; } }
        public override int PlazoMaximo { get { return 36; } }
        public override decimal TasaAnual { get { return 15m; } }
        public override string Requisito { get { return "Demostrar ingresos mensuales estables"; } }
        public override string[] GarantiasPermitidas { get { return new[] { "Personal" }; } }
    }

    public class PrestamoProductivo : PrestamoBase
    {
        public override string Nombre { get { return "Productivo"; } }
        public override decimal MontoMinimo { get { return 10000m; } }
        public override decimal MontoMaximo { get { return 100000m; } }
        public override int PlazoMinimo { get { return 12; } }
        public override int PlazoMaximo { get { return 48; } }
        public override decimal TasaAnual { get { return 12m; } }
        public override string Requisito { get { return "Presentar información de la actividad productiva e ingresos"; } }
        public override string[] GarantiasPermitidas { get { return new[] { "Personal", "Prendaria" }; } }
    }

    public class PrestamoVivienda : PrestamoBase
    {
        public override string Nombre { get { return "Vivienda"; } }
        public override decimal MontoMinimo { get { return 30000m; } }
        public override decimal MontoMaximo { get { return 200000m; } }
        public override int PlazoMinimo { get { return 24; } }
        public override int PlazoMaximo { get { return 120; } }
        public override decimal TasaAnual { get { return 10m; } }
        public override string Requisito { get { return "Demostrar ingresos estables y presentar documentación del inmueble"; } }
        public override string[] GarantiasPermitidas { get { return new[] { "Hipotecaria" }; } }
    }

    // ===== Fábrica que entrega la estrategia según el tipo =====
    public static class PrestamoFactory
    {
        public static IPrestamoStrategy[] Todas()
        {
            return new IPrestamoStrategy[]
            {
                new PrestamoConsumo(),
                new PrestamoProductivo(),
                new PrestamoVivienda()
            };
        }

        public static IPrestamoStrategy ObtenerEstrategia(string tipo)
        {
            return Todas().FirstOrDefault(e => e.Nombre == tipo);
        }
    }
}