using ProyectoBiblioteca.Data.Connection;
using ProyectoBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ProyectoBiblioteca.Data.Repositories
{
    public class LibroDAO
    {
        //Método para registrar un nuevo libro
        public void Registrar(Libros libro)
        {
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();
                    string query = @"
                        INSERT INTO Libros (ISBN, Titulo, Autor, Año, Stock, IDAdminRegistra) 
                        VALUES (@isbn, @titulo, @autor, @anio, @stock, @idAdmin)";

                    SqlCommand cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@isbn", libro.ISBN);
                    cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@anio", libro.Año);
                    cmd.Parameters.AddWithValue("@stock", libro.Stock);
                    cmd.Parameters.AddWithValue("@idAdmin", libro.IDAdminRegistra);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Libros> Listar()
        {
            List<Libros> lista = new List<Libros>();

            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                try
                {
                    cn.Open();
                    string query = "SELECT IDLibro, ISBN, Titulo, Autor, Año, Stock, IDAdminRegistra FROM Libros";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Libros libro = new Libros();
                        libro.IDLibro = Convert.ToInt32(dr["IDLibro"]);
                        libro.ISBN = dr["ISBN"].ToString();
                        libro.Titulo = dr["Titulo"].ToString();
                        libro.Autor = dr["Autor"].ToString();
                        libro.Año = Convert.ToInt32(dr["Año"]); 
                        libro.Stock = Convert.ToInt32(dr["Stock"]);
                        libro.IDAdminRegistra = Convert.ToInt32(dr["IDAdminRegistra"]);
                        lista.Add(libro);
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