using System.Collections.Generic;
using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class RolDatos
    {
        public static List<Rol> ObtenerTodos()
        {
            List<Rol> lista = new List<Rol>();

            string query = "SELECT IdRol, NombreRol, Descripcion, Estado FROM Roles ORDER BY IdRol";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Rol
                        {
                            IdRol = (int)reader["IdRol"],
                            NombreRol = reader["NombreRol"].ToString(),
                            Descripcion = reader["Descripcion"] == System.DBNull.Value ? null : reader["Descripcion"].ToString(),
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}