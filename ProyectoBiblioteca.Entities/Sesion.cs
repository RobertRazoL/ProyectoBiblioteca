using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Entities
{
    //Clase estática
    //Herramienta de memoria RAM para almacenar los datos del admin que inició sesión.
    public static class Sesion
    {
        public static int IDAdmin { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }
    }
}