using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Data.Connection;
using ProyectoBiblioteca.Entities;

namespace ProyectoBiblioteca.Data.Repositories
{
    public class PrestamoDAO
    {
        public List<DetallePrestamo> ListarHistorial()
        {
           List<DetallePrestamo> lista = new List<DetallePrestamo>();

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();

                    string query = @"
                        select A.IDPrestamo, B.Titulo, C.Nombres+' '+C.ApellidoPaterno+' '+C.ApellidoMaterno  as NombreSocio, A.FechaPrestamo, A.FechaDevolucion, D.NombreUsuario as AdminUser  from Prestamos A join Libros B on A.IDLibro = B.IDLibro
                        join Socios C on A.IDSocio = C.IDSocio 
                        join Administradores D on D.IDAdmin = A.IDAdminRegistra order by A.FechaPrestamo DESC";

                    SqlCommand cmd = new SqlCommand(query,cn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read()) {
                        //Creo el objeto temporal para almacenar cada registro
                        DetallePrestamo item = new DetallePrestamo();
                        //Mapeo los datos
                        item.IDPrestamo = Convert.ToInt32(dr["IDPrestamo"]);
                        item.Libro = dr["Titulo"].ToString();
                        item.Socio = dr["NombreSocio"].ToString();
                        item.RegistradoPor = dr["AdminUser"].ToString();
                        //Formato de fecha
                        DateTime fPrestamo = Convert.ToDateTime(dr["FechaPrestamo"]);
                        item.FechaPrestamo = fPrestamo.ToString("dd/MM/yyyy");

                        if (dr["FechaDevolucion"] != DBNull.Value)
                        {
                            DateTime fDev = Convert.ToDateTime(dr["FechaDevolucion"]);
                            item.FechaDevolucion = fDev.ToString("dd/MM/yyyy");
                            item.Estado = "Devuelto";
                        }
                        else
                        {
                            item.FechaDevolucion = "---";
                            item.Estado = "Pendiente"; // Si es NULL, sigue prestado
                        }

                        lista.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return lista;
            }
        }

    }
}
