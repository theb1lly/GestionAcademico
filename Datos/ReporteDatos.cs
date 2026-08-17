using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionAcademico.Datos
{
    public static class ReporteDatos
    {
        public static int ContarUsuarios()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM Usuarios");
        }

        public static int ContarEstudiantes()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM Estudiantes");
        }

        public static int ContarDocentes()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM Docentes");
        }

        public static int ContarAsignaturas()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM Asignaturas");
        }

        public static int ContarInscripciones()
        {
            return EjecutarConteo("SELECT COUNT(*) FROM Inscripciones");
        }

        public static decimal ObtenerPromedioGeneral()
        {
            string query = "SELECT ISNULL(AVG(Nota), 0) FROM Calificaciones";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado == System.DBNull.Value ? 0 : (decimal)resultado;
            }
        }

        private static int EjecutarConteo(string query)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
