using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class EstudianteDatos
    {
        public static List<Estudiante> ObtenerTodos()
        {
            List<Estudiante> lista = new List<Estudiante>();

            string query = @"
                SELECT E.IdEstudiante, E.IdUsuario, U.Nombre, U.Apellido,
                       E.Codigo, E.Carrera, E.Semestre, E.Estado
                FROM Estudiantes E
                INNER JOIN Usuarios U ON E.IdUsuario = U.IdUsuario
                ORDER BY E.IdEstudiante";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Estudiante
                        {
                            IdEstudiante = (int)reader["IdEstudiante"],
                            IdUsuario = (int)reader["IdUsuario"],
                            NombreCompleto = reader["Nombre"] + " " + reader["Apellido"],
                            Codigo = reader["Codigo"].ToString(),
                            Carrera = reader["Carrera"] == System.DBNull.Value ? null : reader["Carrera"].ToString(),
                            Semestre = reader["Semestre"] == System.DBNull.Value ? (int?)null : (int)reader["Semestre"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }

        public static void Insertar(int idUsuario, string codigo, string carrera, int? semestre)
        {
            string query = @"
                INSERT INTO Estudiantes (IdUsuario, Codigo, Carrera, Semestre, Estado)
                VALUES (@IdUsuario, @Codigo, @Carrera, @Semestre, 1)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Carrera", (object)carrera ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Semestre", (object)semestre ?? System.DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}