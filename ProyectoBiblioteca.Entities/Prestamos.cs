using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    //Clase que mapea la tabla Prestamos en la base de datos
    public class Prestamos
    {
        //Propiedades que mapean la tabla Prestamos
        public int IDPrestamo { get; set; }
        public int IDLibro { get; set; }
        public int IDSocio { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IDAdminRegistra { get; set; }

        //Propiedades adicionales para facilitar consultas
        public String TituloLibro { get; set; } 
        public String NombreSocio { get; set; }


    }
}


