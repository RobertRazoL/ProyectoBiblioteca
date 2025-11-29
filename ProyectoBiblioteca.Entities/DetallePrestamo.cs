using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoBiblioteca.Entities
{
    //Clase para transportar los datos del Historial de Préstamos
    public class DetallePrestamo
    {
        // Clase auxiliar para moldear los datos del historial de préstamos. Crea una lista de objetos de este tipo.
        public int IDPrestamo { get; set; }
        public string Libro { get; set; }
        public string Socio { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }
        public string Estado { get; set; }
        public string RegistradoPor { get; set; }

    }
}
