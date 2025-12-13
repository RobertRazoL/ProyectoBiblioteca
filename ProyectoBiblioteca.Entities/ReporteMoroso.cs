using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    public class ReporteMoroso
    {
        public string NombreSocio { get; set; }
        public string Telefono { get; set; } // Importante para cobrarle
        public string Correo { get; set; }

        // Datos del Libro y Préstamo
        public string TituloLibro { get; set; }
        public string FechaPrestamo { get; set; }

        // Dato Calculado
        public int DiasRetraso { get; set; } // Cuántos días debe
    }
}
