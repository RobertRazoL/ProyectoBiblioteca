using ProyectoBiblioteca.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Entities;

namespace ProyectoBiblioteca.Business.Services
{
    public class PrestamoService
    {
        //Declaro mi variable para manejar los datos
        private readonly PrestamoDAO prestamoDAO;

        //El constructor 
        public PrestamoService()
        {
            prestamoDAO = new PrestamoDAO();
        }

        //La acción para ver el Historial
        public List<DetallePrestamo> VerHistorial()
        {
            return prestamoDAO.ListarHistorial();
        }

        public bool RegistrarPrestamo(Prestamos obj, out string mensaje)
        {
            // 1. Validaciones de Negocio (Reglas antes de ir a la BD)
            if (obj.IDLibro == 0)
            {
                mensaje = "Debes seleccionar un Libro de la lista.";
                return false;
            }

            if (obj.IDSocio == 0)
            {
                mensaje = "Debes seleccionar un Socio de la lista.";
                return false;
            }

            // 2. Si pasa las validaciones, llamamos al DAO
            return prestamoDAO.RegistrarPrestamo(obj, out mensaje);
        }

    }
}
