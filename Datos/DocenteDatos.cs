using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class DocenteDatos
    {
        public static List<Docente> ObtenerTodos()
        {
            List<Docente> lista = new List<Docente>();

            string query = @"
                SELECT D.IdDocente, D.IdUsuario, U.Nombre, U.Apellido,
                       D.Especialidad, D.Estado
                FROM Docentes D
                INNER JOIN Usuarios U ON D.IdUsuario = U.IdUsuario
                ORDER BY D.IdDocente";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Docente
                        {
                            IdDocente = (int)reader["IdDocente"],
                            IdUsuario = (int)reader["IdUsuario"],
                            NombreCompleto = reader["Nombre"] + " " + reader["Apellido"],
                            Especialidad = reader["Especialidad"] == System.DBNull.Value ? null : reader["Especialidad"].ToString(),
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }

        public static void Insertar(int idUsuario, string especialidad)
        {
            string query = "INSERT INTO Docentes (IdUsuario, Especialidad, Estado) VALUES (@IdUsuario, @Especialidad, 1)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Especialidad", (object)especialidad ?? System.DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}