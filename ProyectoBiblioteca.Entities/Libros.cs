using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    //Sirve para mover los datos del libro (formulario) hasta el SQL Server
    public class Libros
    {
        public int IDLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }
        public int Stock { get; set; }
        public int IDAdminRegistra { get; set; }
        public Administradores Administradores { get; set; }
    }
}
