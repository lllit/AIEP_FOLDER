using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EmpleadoNegocio
    {
        // Instancia de la clase Conexion de la CapaDatos
        private Conexion conexion = new Conexion();

        // Método para agregar un nuevo empleado
        public bool AgregarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "INSERT INTO Empleados (Rut, Nombre, Direccion, Telefono, ValorHora, ValorHoraExtra, IdAFP, IdSalud) " +
                                   "VALUES (@Rut, @Nombre, @Direccion, @Telefono, @ValorHora, @ValorHoraExtra, @IdAFP, @IdSalud)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Rut", empleado.Rut);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@ValorHora", empleado.ValorHora);
                    cmd.Parameters.AddWithValue("@ValorHoraExtra", empleado.ValorHoraExtra);
                    cmd.Parameters.AddWithValue("@IdAFP", empleado.IdAFP);
                    cmd.Parameters.AddWithValue("@IdSalud", empleado.IdSalud);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar empleado: " + ex.Message);
            }
        }

        // Método para obtener todos los empleados
        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT * FROM Empleado";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Empleado empleado = new Empleado
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
                        listaEmpleados.Add(empleado);
                    }
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar empleados: " + ex.Message);
            }
            return listaEmpleados;
        }


        public bool guardarEmpleado(Empleado empleado, int horasTrabajadas, int horasExtras)
        {
            if (empleado == null)
            {
                throw new ArgumentNullException(nameof(empleado), "El empleado no puede ser nulo.");
            }


            try
            {
                using (SqlConnection con = conexion.ObtenerConexion())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GuardarEmpleadoYCalculoSueldo", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetros del empleado
                        cmd.Parameters.AddWithValue("@Rut", empleado.Rut);
                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@ValorHora", empleado.ValorHora);
                        cmd.Parameters.AddWithValue("@ValorHoraExtra", empleado.ValorHoraExtra);
                        cmd.Parameters.AddWithValue("@IdAFP", empleado.IdAFP);
                        cmd.Parameters.AddWithValue("@IdSalud", empleado.IdSalud);

                        // Parámetros para cálculo de sueldo
                        cmd.Parameters.AddWithValue("@HorasTrabajadas", horasTrabajadas);
                        cmd.Parameters.AddWithValue("@HorasExtras", horasExtras);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar empleado: " + ex.Message);
            }
        }




    }
}
