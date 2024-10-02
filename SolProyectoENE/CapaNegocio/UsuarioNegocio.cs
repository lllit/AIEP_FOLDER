using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private Conexion conexion = new Conexion();
        //TEST 1
        // Método para validar usuario
        public Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            Usuario usuario = null;

            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();

                    string query = "SELECT * FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si encuentra un usuario, lo mapea a la clase Usuario
                        usuario = new Usuario
                        {
                            IdUsuario = (int)reader["IdUsuario"],
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            IdRol = (int)reader["IdRol"],
                            IdEmpleado = (int)reader["IdEmpleado"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }

            return usuario;
        }


        // Método para agregar un nuevo usuario
        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO Usuarios (NombreUsuario, Contraseña, IdRol, IdEmpleado) " +
                                   "VALUES (@NombreUsuario, @Contraseña, @IdRol, @IdEmpleado)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                    cmd.Parameters.AddWithValue("@IdEmpleado", usuario.IdEmpleado);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
        }

        
    }
}
