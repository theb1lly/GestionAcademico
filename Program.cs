using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademico
{
    public static class Conexion
    {
        // Aquí declaras la cadena UNA sola vez, con un nombre
        public static readonly string CadenaConexion =
            "Server=db64078.public.databaseasp.net;" +
            "Database=db64078;" +
            "User Id=db64078;" +
            "Password=R!w9t6=CHy2-;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;" +
            "MultipleActiveResultSets=True;";

        // Método que devuelve una conexión ya lista para usar
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }

internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
