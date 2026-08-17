using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class AsignaturaDatos
    {
        public static List<Asignatura> ObtenerTodos()
        {
            List<Asignatura> lista = new List<Asignatura>();

            string query = @"
                SELECT A.IdAsignatura, A.Nombre, A.Codigo, A.Creditos,
                       A.IdDocente, A.Estado
                FROM Asignaturas A
                ORDER BY A.IdAsignatura";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Asignatura
                        {
                            IdAsignatura = (int)reader["IdAsignatura"],
                            Nombre = reader["Nombre"].ToString(),
                            Codigo = reader["Codigo"].ToString(),
                            Creditos = (int)reader["Creditos"],
                            IdDocente = reader["IdDocente"] == System.DBNull.Value ? (int?)null : (int)reader["IdDocente"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }

        public static void Insertar(string nombre, string codigo, int creditos, int? idDocente)
        {
            string query = @"
                INSERT INTO Asignaturas (Nombre, Codigo, Creditos, IdDocente, Estado)
                VALUES (@Nombre, @Codigo, @Creditos, @IdDocente, 1)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Creditos", creditos);
                cmd.Parameters.AddWithValue("@IdDocente", (object)idDocente ?? System.DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}