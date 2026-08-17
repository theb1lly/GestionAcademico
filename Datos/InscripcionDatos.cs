using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class InscripcionDatos
    {
        public static List<Inscripcion> ObtenerPorEstudiante(int idEstudiante)
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            string query = @"
                SELECT I.IdInscripcion, I.IdEstudiante, I.IdAsignatura,
                       A.Nombre AS NombreAsignatura, I.IdPeriodo,
                       P.Nombre AS NombrePeriodo, I.FechaInscripcion, I.Estado
                FROM Inscripciones I
                INNER JOIN Asignaturas A ON I.IdAsignatura = A.IdAsignatura
                INNER JOIN Periodos P ON I.IdPeriodo = P.IdPeriodo
                WHERE I.IdEstudiante = @IdEstudiante
                ORDER BY I.IdInscripcion";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);

                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Inscripcion
                        {
                            IdInscripcion = (int)reader["IdInscripcion"],
                            IdEstudiante = (int)reader["IdEstudiante"],
                            IdAsignatura = (int)reader["IdAsignatura"],
                            NombreAsignatura = reader["NombreAsignatura"].ToString(),
                            IdPeriodo = (int)reader["IdPeriodo"],
                            NombrePeriodo = reader["NombrePeriodo"].ToString(),
                            FechaInscripcion = (System.DateTime)reader["FechaInscripcion"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }

        public static List<Inscripcion> ObtenerTodas()
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            string query = @"
        SELECT I.IdInscripcion, I.IdEstudiante, U.Nombre + ' ' + U.Apellido AS NombreEstudiante,
               I.IdAsignatura, A.Nombre AS NombreAsignatura,
               I.IdPeriodo, P.Nombre AS NombrePeriodo,
               I.FechaInscripcion, I.Estado
        FROM Inscripciones I
        INNER JOIN Estudiantes E ON I.IdEstudiante = E.IdEstudiante
        INNER JOIN Usuarios U ON E.IdUsuario = U.IdUsuario
        INNER JOIN Asignaturas A ON I.IdAsignatura = A.IdAsignatura
        INNER JOIN Periodos P ON I.IdPeriodo = P.IdPeriodo
        ORDER BY I.IdInscripcion";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Inscripcion
                        {
                            IdInscripcion = (int)reader["IdInscripcion"],
                            IdEstudiante = (int)reader["IdEstudiante"],
                            NombreEstudiante = reader["NombreEstudiante"].ToString(),
                            IdAsignatura = (int)reader["IdAsignatura"],
                            NombreAsignatura = reader["NombreAsignatura"].ToString(),
                            IdPeriodo = (int)reader["IdPeriodo"],
                            NombrePeriodo = reader["NombrePeriodo"].ToString(),
                            FechaInscripcion = (System.DateTime)reader["FechaInscripcion"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }

        public static void Insertar(int idEstudiante, int idAsignatura, int idPeriodo)
        {
            string query = @"
                INSERT INTO Inscripciones (IdEstudiante, IdAsignatura, IdPeriodo, Estado)
                VALUES (@IdEstudiante, @IdAsignatura, @IdPeriodo, 1)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@IdAsignatura", idAsignatura);
                cmd.Parameters.AddWithValue("@IdPeriodo", idPeriodo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}