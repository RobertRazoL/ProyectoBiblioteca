using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    public class ReportePrestamo
    {
        //Defino las propiedades que necesito para el reporte
        public int IDPrestamo { get; set; }
        public string Libro { get; set; }
        public string Socio { get; set; }       
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }
        public string Estado { get; set; }      
        public string Bibliotecario { get; set; } 
    }
}
