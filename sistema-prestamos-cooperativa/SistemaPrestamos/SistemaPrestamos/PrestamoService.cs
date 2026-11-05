
using System;
using System.Collections.Generic;

namespace SistemaPrestamos
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos;

        public PrestamoService()
        {
            prestamos = new List<Prestamo>();
        }

        public List<Prestamo> ListarPrestamos()
        {
            return prestamos;
        }

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo != null)
            {
                prestamos.Add(prestamo);
            }
        }
    }
}
