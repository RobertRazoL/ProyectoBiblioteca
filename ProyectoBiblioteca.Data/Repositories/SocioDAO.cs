using ProyectoBiblioteca.Data.Connection;
using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Data.Repositories
{
    public class SocioDAO
    {
        //Método para registrar un nuevo socio
        public void Registrar(Socios socio)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
                try
                {
                    cn.Open();
                    string query = @"
                        INSERT INTO Socios (Nombres, Apellidos, Direccion, Telefono, Correo, IDAdminRegistra) 
                        VALUES (@nombres, @apellidos, @direccion, @telefono, @correo, @idAdmin)";
                    
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@nombres", socio.Nombres);
                    cmd.Parameters.AddWithValue("@apellidos", socio.Apellidos);
                    cmd.Parameters.AddWithValue("@direccion", socio.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", socio.Telefono);
                    cmd.Parameters.AddWithValue("@correo", socio.Correo);
                    cmd.Parameters.AddWithValue("@idAdmin", socio.IDAdminRegistra);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public List<Socios> Listar()
        {
            List<Socios> lista = new List<Socios>();
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();
                    string query = "SELECT IDSocio, Nombres, Apellidos, Direccion, Telefono, Correo, IDAdminRegistra FROM Socios";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Socios socio = new Socios();
                        socio.IDSocio = Convert.ToInt32(dr["IDSocio"]);
                        socio.Nombres = dr["Nombres"].ToString();
                        socio.Apellidos = dr["Apellidos"].ToString();
                        socio.Direccion = dr["Direccion"].ToString();
                        socio.Telefono = dr["Telefono"].ToString();
                        socio.Correo = dr["Correo"].ToString();
                        socio.IDAdminRegistra = Convert.ToInt32(dr["IDAdminRegistra"]);
                        lista.Add(socio);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return lista;
        }
    }
}
