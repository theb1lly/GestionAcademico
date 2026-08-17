using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class PeriodoDatos
    {
        public static List<Periodo> ObtenerTodos()
        {
            List<Periodo> lista = new List<Periodo>();

            string query = "SELECT IdPeriodo, Nombre, FechaInicio, FechaFin, Estado FROM Periodos ORDER BY IdPeriodo";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Periodo
                        {
                            IdPeriodo = (int)reader["IdPeriodo"],
                            Nombre = reader["Nombre"].ToString(),
                            FechaInicio = (System.DateTime)reader["FechaInicio"],
                            FechaFin = (System.DateTime)reader["FechaFin"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}