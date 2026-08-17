using System.Data.SqlClient;
using GestionAcademico.Modelos;

namespace GestionAcademico.Datos
{
    public static class UsuarioDatos
    {
        public static Usuario ValidarLogin(string nombreUsuario, byte[] passwordHash)
        {
            Usuario usuario = null;

            string query = @"
                SELECT U.IdUsuario, U.Nombre, U.Apellido, U.Correo,
                       U.NombreUsuario, R.NombreRol, U.Estado
                FROM Usuarios U
                INNER JOIN Roles R ON U.IdRol = R.IdRol
                WHERE U.NombreUsuario = @NombreUsuario
                  AND U.PasswordHash = @PasswordHash";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Rol = reader["NombreRol"].ToString(),
                            Estado = (bool)reader["Estado"]
                        };
                    }
                }
            }

            return usuario;
        }
    }
}