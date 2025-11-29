using System.Data.SqlClient;

namespace ProyectoBiblioteca.Data.Connection
{
    public class ConnectionDB
    {
        private static readonly string 
            connectionString = "Server=localhost\\SQLEXPRESS;Database=BDLibreria;Trusted_Connection=True;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }

}
