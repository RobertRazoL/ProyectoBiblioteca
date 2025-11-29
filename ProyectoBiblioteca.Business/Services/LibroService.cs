using ProyectoBiblioteca.Data.Repositories;
using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Business.Services
{
    //Valida los datos del libro antes de enviarlos al DAO para su registro en el SQL Server
    public class LibroService
    {
        //Declaro el DAO para conectar con la capa de datos
        private readonly LibroDAO libroDAO;
        public LibroService()
        {
            //Preparo el DAO para conectar con la capa de datos
            libroDAO = new LibroDAO();
        }
        public void RegistrarLibro(Libros libro)
        {

            //Evitamos que lleguen datos vacíos o inválidos al registro
            if (string.IsNullOrWhiteSpace(libro.ISBN))
            {
                throw new Exception("El ISBN es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(libro.Titulo))
            {
                throw new Exception("El Título del libro es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(libro.Autor))
            {
                throw new Exception("El Autor del libro es obligatorio.");
            }
            if (libro.Año<=0)
            {
                throw new Exception("El Año del libro es obligatorio y debe ser valido.");
            }
            if (libro.Stock < 0)
            {
                throw new Exception("El stock no puede ser negativo.");
            }

            //Llamamos al DAO para registrar el libro en el SQL
            libroDAO.Registrar(libro);
        }

        public List<Libros> ListarLibros()
        {
            return libroDAO.Listar();
        }

    }
}
