using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    public class Prestamos
    {
        public int IDPrestamo { get; set; }
        public Libros Libros { get; set; }
        public Socios Socios { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Administradores Administradores { get; set; }
    }
}


