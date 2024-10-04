using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TrabajadorDatos
    {
        private string connectionString = "Data Source=.;Initial Catalog=BD_ene;Integrated Security=True"; // Asegúrate de usar la cadena de conexión correcta.

        // Método para insertar un trabajador en la base de datos
        public void InsertarTrabajador(Empleado trabajador)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Empleado (Rut, Nombre, Direccion, Telefono, HorasTrabajadas, HorasExtras, AFP, Salud, SueldoBruto, SueldoLiquido) " +
                               "VALUES (@Rut, @Nombre, @Direccion, @Telefono, @HorasTrabajadas, @HorasExtras, @AFP, @Salud, @SueldoBruto, @SueldoLiquido)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Rut", trabajador.Rut);
                cmd.Parameters.AddWithValue("@Nombre", trabajador.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", trabajador.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", trabajador.Telefono);
                //cmd.Parameters.AddWithValue("@HorasTrabajadas", trabajador.HorasTrabajadas);
                //cmd.Parameters.AddWithValue("@HorasExtras", trabajador.HorasExtras);
                cmd.Parameters.AddWithValue("@AFP", trabajador.AFP);
                cmd.Parameters.AddWithValue("@Salud", trabajador.Salud);
                //cmd.Parameters.AddWithValue("@SueldoBruto", trabajador.SueldoBruto);
                //cmd.Parameters.AddWithValue("@SueldoLiquido", trabajador.SueldoLiquido);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener la lista de AFP
        public DataTable ObtenerListaAfp()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre FROM AFP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable afpTable = new DataTable();
                adapter.Fill(afpTable);
                return afpTable;
            }
        }

        // Método para obtener la lista de Salud
        public DataTable ObtenerListaSalud()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre FROM Salud";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable saludTable = new DataTable();
                adapter.Fill(saludTable);
                return saludTable;
            }
        }

        // Método para obtener el descuento de AFP (ejemplo: 10% de descuento)
        public decimal ObtenerDescuentoAfp(string afp)
        {
            // Aquí puedes aplicar lógica personalizada según la AFP
            // Ejemplo simple: todas las AFP tienen un 10% de descuento
            return 0.10m;
        }

        // Método para obtener el descuento de Salud (ejemplo: 7% de descuento)
        public decimal ObtenerDescuentoSalud(string salud)
        {
            // Aquí puedes aplicar lógica personalizada según la salud
            // Ejemplo simple: todas las instituciones de salud tienen un 7% de descuento
            return 0.07m;
        }

        // Método para obtener todos los trabajadores registrados en la base de datos
        public DataTable ObtenerTodosLosTrabajadores()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleado";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable empleadosTable = new DataTable();
                adapter.Fill(empleadosTable);
                return empleadosTable;
            }
        }
    }
}
