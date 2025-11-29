
using ProyectoBiblioteca.Data.Repositories;
using ProyectoBiblioteca.Entities;
using System;

namespace ProyectoBiblioteca.Business.Service
{
    //Valida los datos del login antes de enviarlos al DAO
    public class LoginService
    {
        private readonly LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        public Administradores Login(string usuario, string clave)
        {
            if(string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception("Debe ingresar el Nombre de Usuario");
            }

            if(string.IsNullOrWhiteSpace(clave))
            {
                throw new Exception("Debe ingresar la Contraseña");
            }

            Administradores administradores = loginDAO.Login(usuario, clave);

            if (administradores == null)
            {
                throw new Exception("Usuario o Contraseña incorrectos");
            }

            return administradores;
        }

    }
}
