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
        
        
    }
}
