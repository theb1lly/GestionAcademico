using System.Data.SqlClient;

namespace GestionAcademico.Datos
{
    public static class Conexion
    {
        public static readonly string CadenaConexion =
            "Server=db64078.public.databaseasp.net;" +
            "Database=db64078;" +
            "User Id=db64078;" +
            "Password=R!w9t6=CHy2-;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;" +
            "MultipleActiveResultSets=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}