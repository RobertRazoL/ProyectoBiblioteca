using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Data.Repositories;
using ProyectoBiblioteca.Entities;

namespace ProyectoBiblioteca.Business.Services
{
    public class SocioService
    {
        //Declaro la herramienta DAO
        private readonly SocioDAO socioDAO;
        public SocioService()
        {
            //Preparo la herramienta DAO
            socioDAO = new SocioDAO();
        }

        public void RegistrarSocio(Socios socio)
        {
            //Validaciones básicas
            if(string.IsNullOrWhiteSpace(socio.NombreUsuario))
            {
                throw new Exception("El nombre de usuario es obligatorio.");
            }
            if(string.IsNullOrWhiteSpace(socio.Contraseña))
            {
                throw new Exception("La contraseña es obligatoria.");
            }
            if (string.IsNullOrWhiteSpace(socio.Nombres))
            {
                throw new Exception("El nombre es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(socio.ApellidoPaterno))
            {
                throw new Exception("Los apellidos son obligatorios.");
            }
            if (string.IsNullOrWhiteSpace(socio.ApellidoMaterno))
            {
                throw new Exception("Los apellidos son obligatorios.");
            }
            if (string.IsNullOrWhiteSpace(socio.Direccion))
            {
                throw new Exception("La dirección es obligatoria.");
            }
            if (string.IsNullOrWhiteSpace(socio.Telefono))
            {
                throw new Exception("El teléfono es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(socio.Correo))
            {
                throw new Exception("El correo es obligatorio.");
            }
            //Llamamos al DAO para registrar el socio en el SQL
            socioDAO.Registrar(socio);
        }

        public List<Socios> ListarSocios()
        {
            return socioDAO.Listar();
        }
    }
}
