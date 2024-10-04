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

        public Empleado ObtenerEmpleadoPorId(int idEmpleado)
        {
            using (SqlConnection conn = new Conexion().ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado WHERE IdEmpleado = @IdEmpleado", conn))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Empleado
                            {
                                IdEmpleado = (int)reader["IdEmpleado"],
                                Rut = reader["Rut"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                ValorHora = (decimal)reader["ValorHora"],
                                ValorHoraExtra = (decimal)reader["ValorHoraExtra"],
                                IdAFP = (int)reader["IdAFP"],
                                IdSalud = (int)reader["IdSalud"]
                            };
                        }
                    }
                }
                conn.Close();
            }
            return null;
        }





        // Método para validar si el usuario es administrador
        public bool EsAdmin(Usuario usuario)
        {
            // Asumimos que el IdRol para administrador es 1
            return usuario.Rol != null && usuario.Rol.IdRol == 1;
        }

        // Método para validar si el usuario es un empleado normal
        public bool EsUsuarioNormal(Usuario usuario)
        {
            // Asumimos que el IdRol para usuario normal es 2
            return usuario.Rol != null && usuario.Rol.IdRol == 2;
        }

        // Método genérico para validar el rol del usuario
        public bool ValidarRolUsuario(int idUsuario, string nombreRol)
        {
            bool esValido = false;

            using (SqlConnection conn = new Conexion().ObtenerConexion())
            {
                try
                {
                    conn.Open();

                    // Consulta SQL para obtener el rol del usuario
                    string consulta = "SELECT r.NombreRol FROM Usuario u " +
                                      "INNER JOIN RolUsuario r ON u.IdRol = r.IdRol " +
                                      "WHERE u.IdUsuario = @IdUsuario AND r.NombreRol = @NombreRol";

                    using (SqlCommand comando = new SqlCommand(consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@NombreRol", nombreRol);

                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            esValido = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra durante la conexión
                    Console.WriteLine("Error al validar el rol del usuario: " + ex.Message);
                }
            }

            return esValido;
        }
    
        
    }
}
