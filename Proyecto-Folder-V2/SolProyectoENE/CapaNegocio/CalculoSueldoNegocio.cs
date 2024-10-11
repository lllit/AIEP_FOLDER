using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CalculoSueldoNegocio
    {
        Conexion conexion = new Conexion();

        // Método para calcular el sueldo de un empleado
        public decimal CalcularSueldo(Empleado empleado, int horasTrabajadas, int horasExtras)
        {
            // Calculo básico de sueldo
            decimal sueldoBruto = (empleado.ValorHora * horasTrabajadas) + (empleado.ValorHoraExtra * horasExtras);

            // Obtener los descuentos de AFP y Salud
            decimal descuentoAFP = sueldoBruto * ObtenerDescuentoAFP(empleado.IdAFP);
            decimal descuentoSalud = sueldoBruto * ObtenerDescuentoSalud(empleado.IdSalud);

            // Calcular el sueldo líquido
            decimal sueldoLiquido = sueldoBruto - (descuentoAFP + descuentoSalud);

            return sueldoLiquido;
        }

        // Método para obtener el porcentaje de descuento de AFP
        public decimal ObtenerDescuentoAFP(int idAFP)
        {
            decimal tasaDescuento = 0.0m;
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT TasaDescuento FROM AFP WHERE IdAFP = @IdAFP";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAFP", idAFP);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        tasaDescuento = Convert.ToDecimal(result) / 100; // Dividir por 100 para convertirlo a porcentaje
                    }
                }
                
            }
            return tasaDescuento;

        }

        // Método para obtener el porcentaje de descuento de Salud
        public decimal ObtenerDescuentoSalud(int idSalud)
        {
            decimal tasaDescuento = 0.0m;

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT TasaDescuento FROM Salud WHERE IdSalud = @IdSalud";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdSalud", idSalud);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        tasaDescuento = Convert.ToDecimal(result) / 100; // Dividir por 100 para convertirlo a porcentaje
                    }
                }
            }

            return tasaDescuento;
        }




        public decimal ObtenerSueldoLiquidoPorIdEmpleado(int idEmpleado)
        {
            decimal sueldoLiquido= 0;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT SueldoLiquido FROM CalculoSueldo WHERE IdEmpleado = @IdEmpleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        sueldoLiquido = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el sueldo líquido: " + ex.Message);
                }
            }

            return sueldoLiquido;
        }
    }
}
