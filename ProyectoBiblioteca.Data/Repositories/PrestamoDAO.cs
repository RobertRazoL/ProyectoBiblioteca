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

                    while (dr.Read()) 
                    {
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
            }
            return lista;

        }
       
        public List<ReportePrestamo> ObtenerDatosReporte()
        {
            List<ReportePrestamo> lista = new List<ReportePrestamo>();

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();
                    // Se uso el mismo query que en ListarHistorial pero adaptado al nuevo objeto
                    string query = @"
                        SELECT 
                            A.IDPrestamo, 
                            B.Titulo, 
                            C.Nombres + ' ' + C.ApellidoPaterno + ' ' + C.ApellidoMaterno as NombreSocio, 
                            A.FechaPrestamo, 
                            A.FechaDevolucion, 
                            D.NombreUsuario as AdminUser  
                        FROM Prestamos A 
                        JOIN Libros B on A.IDLibro = B.IDLibro
                        JOIN Socios C on A.IDSocio = C.IDSocio 
                        JOIN Administradores D on D.IDAdmin = A.IDAdminRegistra 
                        ORDER BY A.FechaPrestamo DESC";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        // AQUI USAMOS LA NUEVA ENTIDAD 'ReportePrestamo'
                        ReportePrestamo item = new ReportePrestamo();

                        item.IDPrestamo = Convert.ToInt32(dr["IDPrestamo"]);
                        item.Libro = dr["Titulo"].ToString();
                        item.Socio = dr["NombreSocio"].ToString();
                        item.Bibliotecario = dr["AdminUser"].ToString();

                        DateTime fPrestamo = Convert.ToDateTime(dr["FechaPrestamo"]);
                        item.FechaPrestamo = fPrestamo.ToString("dd/MM/yyyy");

                        // Verifico si la fecha de devolución es NULL
                        if (dr["FechaDevolucion"] != DBNull.Value)
                        {
                           
                            DateTime fDev = Convert.ToDateTime(dr["FechaDevolucion"]);
                            item.FechaDevolucion = fDev.ToString("dd/MM/yyyy");
                            item.Estado = "Devuelto";
                        }
                        else
                        {
                            item.FechaDevolucion = "---";
                            item.Estado = "Pendiente";
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

        public bool RegistrarPrestamo(Prestamos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();

                    // INICIAMOS LA TRANSACCIÓN (Todo o Nada)
                    using (SqlTransaction transaccion = cn.BeginTransaction())
                    {
                        try
                        {
                            // 1. VERIFICAR STOCK
                            string queryStock = "SELECT Stock FROM Libros WHERE IDLibro = @idLibro";
                            SqlCommand cmdStock = new SqlCommand(queryStock, cn, transaccion);
                            cmdStock.Parameters.AddWithValue("@idLibro", obj.IDLibro);

                            // Usamos ExecuteScalar porque solo queremos un numerito (el stock)
                            object resultado = cmdStock.ExecuteScalar();
                            int stockActual = (resultado != null) ? Convert.ToInt32(resultado) : 0;

                            if (stockActual <= 0)
                            {
                                Mensaje = "No hay stock disponible para este libro.";
                                transaccion.Rollback(); // Cancelamos todo
                                return false;
                            }

                            // 2. BAJAR STOCK (Restamos 1)
                            string queryUpdate = "UPDATE Libros SET Stock = Stock - 1 WHERE IDLibro = @idLibro";
                            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, cn, transaccion);
                            cmdUpdate.Parameters.AddWithValue("@idLibro", obj.IDLibro);
                            cmdUpdate.ExecuteNonQuery();

                            // 3. REGISTRAR EL PRÉSTAMO
                            string queryInsert = @"
                                INSERT INTO Prestamos(IDLibro, IDSocio, FechaPrestamo, IDAdminRegistra)
                                VALUES (@idLibro, @idSocio, GETDATE(), @idAdmin)";

                            SqlCommand cmdInsert = new SqlCommand(queryInsert, cn, transaccion);
                            cmdInsert.Parameters.AddWithValue("@idLibro", obj.IDLibro);
                            cmdInsert.Parameters.AddWithValue("@idSocio", obj.IDSocio);
                            cmdInsert.Parameters.AddWithValue("@idAdmin", obj.IDAdminRegistra);

                            cmdInsert.ExecuteNonQuery();

                            // SI TODO SALIÓ BIEN, CONFIRMAMOS LOS CAMBIOS
                            transaccion.Commit();
                            respuesta = true;
                        }
                        catch (Exception ex)
                        {
                            // SI HUBO ERROR, DESHACEMOS LOS CAMBIOS
                            transaccion.Rollback();
                            Mensaje = "Error en transacción: " + ex.Message;
                            respuesta = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = "Error de conexión: " + ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<ReporteMoroso> ObtenerReporteMorosos()
        {
            List<ReporteMoroso> lista = new List<ReporteMoroso>();

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();
                    string query = @"
                SELECT 
                    S.Nombres + ' ' + S.ApellidoPaterno + ' ' + S.ApellidoMaterno AS Socio,
                    S.Telefono, S.Correo,
                    L.Titulo,
                    P.FechaPrestamo,
                    DATEDIFF(day, P.FechaPrestamo, GETDATE()) AS DiasAtraso
                FROM Prestamos P
                JOIN Socios S ON P.IDSocio = S.IDSocio
                JOIN Libros L ON P.IDLibro = L.IDLibro
                WHERE P.FechaDevolucion IS NULL 
                AND DATEDIFF(day, P.FechaPrestamo, GETDATE()) > 7
                ORDER BY DiasAtraso DESC";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ReporteMoroso item = new ReporteMoroso();
                        item.NombreSocio = dr["Socio"].ToString();
                        item.Telefono = dr["Telefono"].ToString();
                        item.Correo = dr["Correo"].ToString();
                        item.TituloLibro = dr["Titulo"].ToString();

                        // Formateamos fecha
                        DateTime fecha = Convert.ToDateTime(dr["FechaPrestamo"]);
                        item.FechaPrestamo = fecha.ToString("dd/MM/yyyy");

                        item.DiasRetraso = Convert.ToInt32(dr["DiasAtraso"]);

                        lista.Add(item);
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return lista;
        }


    }
}
