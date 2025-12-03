using ProyectoBiblioteca.Data.Connection;
using ProyectoBiblioteca.Entities;
using System;
using System.Data.SqlClient;

namespace ProyectoBiblioteca.Data.Repositories
{
    public class LoginDAO
    {
        public Administradores Login(string username, string clave)
        {
            Administradores administradores = null;
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"
                    SELECT *
                    FROM Administradores
                    WHERE NombreUsuario = @usuario
                    AND Contraseña=@clave";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@usuario", username);
                cmd.Parameters.AddWithValue("@clave", clave);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    administradores = new Administradores
                    {

                        IDAdmin = Convert.ToInt32(dr["IDAdmin"]),
                        NombreUsuario = dr["NombreUsuario"].ToString(),
                        Contraseña = dr["Contraseña"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApellidoPaterno = dr["ApellidoPaterno"].ToString(),
                        ApellidoMaterno = dr["ApellidoMaterno"].ToString(),
                        Rol = dr["Rol"].ToString()

                    };
                }
            }
            return administradores;
        }
    }
}
