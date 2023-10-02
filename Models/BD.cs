using System.Data.SqlClient;
using Dapper;

public class BD{
    public static string _connectionString = @"Server=.";
    
    public static List<Usuario> ObtenerDatosUsuario(){
        using (SqlConnection BD = new SqlConnection(_connectionString)){
            string query = "SELECT * FROM Usuario";
            return BD.Query<Usuario>(query).ToList();
        }
    }
}