using GestionAcademico.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademico.Datos
{
    internal class CalificacionDatos
    {
        public static List<Calificacion> ObtenerTodas()
        {
            List<Calificacion> lista = new List<Calificacion>();

            string query = @"
        SELECT C.IdCalificacion, C.IdInscripcion,
               U.Nombre + ' ' + U.Apellido AS NombreEstudiante,
               A.Nombre AS NombreAsignatura,
               C.Nota, C.FechaRegistro
        FROM Calificaciones C
        INNER JOIN Inscripciones I ON C.IdInscripcion = I.IdInscripcion
        INNER JOIN Estudiantes E ON I.IdEstudiante = E.IdEstudiante
        INNER JOIN Usuarios U ON E.IdUsuario = U.IdUsuario
        INNER JOIN Asignaturas A ON I.IdAsignatura = A.IdAsignatura
        ORDER BY C.IdCalificacion";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Calificacion
                        {
                            IdCalificacion = (int)reader["IdCalificacion"],
                            IdInscripcion = (int)reader["IdInscripcion"],
                            NombreAsignatura = reader["NombreAsignatura"].ToString(),
                            Nota = (decimal)reader["Nota"],
                            FechaRegistro = (System.DateTime)reader["FechaRegistro"]
                        });
                    }
                }
            }

            return lista;
        }
        public static void Registrar(int idInscripcion, decimal nota)
        {
            string query = "INSERT INTO Calificaciones (IdInscripcion, Nota) VALUES (@IdInscripcion, @Nota)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdInscripcion", idInscripcion);
                cmd.Parameters.AddWithValue("@Nota", nota);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }


}
