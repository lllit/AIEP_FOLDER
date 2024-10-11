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




        
        
        //Método para obtener todos los empleados
        public List<Empleado> ObtenerTodosLosEmpleados()
        {
            var empleados = new List<Empleado>();
            using (SqlConnection conn = new Conexion().ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleados.Add(new Empleado
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
                            });
                        }
                    }
                }
                conn.Close();
            }
            return empleados;
        }

    }
}
