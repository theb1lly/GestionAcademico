using GestionAcademico.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionAcademico.Datos
{

    public static class UsuarioDatos
    {
        public static int Insertar(string nombre, string apellido, string correo,
    string nombreUsuario, byte[] passwordHash, int idRol)
        {
            string query = @"
        INSERT INTO Usuarios (Nombre, Apellido, Correo, NombreUsuario, PasswordHash, IdRol, Estado)
        OUTPUT INSERTED.IdUsuario
        VALUES (@Nombre, @Apellido, @Correo, @NombreUsuario, @PasswordHash, @IdRol, 1)";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.Parameters.AddWithValue("@IdRol", idRol);

                cn.Open();
                int idUsuario = (int)cmd.ExecuteScalar();
                return idUsuario;
            }
        }
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

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            string query = @"
        SELECT U.IdUsuario, U.Nombre, U.Apellido, U.Correo,
               U.NombreUsuario, R.NombreRol, U.Estado
        FROM Usuarios U
        INNER JOIN Roles R ON U.IdRol = R.IdRol
        ORDER BY U.IdUsuario";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Rol = reader["NombreRol"].ToString(),
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}