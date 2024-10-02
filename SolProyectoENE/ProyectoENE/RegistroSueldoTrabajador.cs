using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;


namespace ProyectoENE
{
    public partial class RegistroSueldoTrabajador : Form
    {

        private Conexion conexion;
        private CalculoSueldoNegocio calculoSueldoNegocio;
        private CN_Recursos recursosNegocio;

        public RegistroSueldoTrabajador()
        {
            InitializeComponent();

        }
        private void RegistroSueldoTrabajador_Load(object sender, EventArgs e)
        {
            conexion = new Conexion();
            calculoSueldoNegocio = new CalculoSueldoNegocio();
            
            CargarDatosComboBoxes();
        }

        // Método para cargar los ComboBox con datos de la base de datos
        private void CargarDatosComboBoxes()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // Cargar AFP
                using (SqlCommand cmd = new SqlCommand("SELECT IdAFP, NombreAFP FROM AFP", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmb_afp.Items.Add("Seleccionar");
                    while (reader.Read())
                    {
                        cmb_afp.Items.Add(new { Text = reader["NombreAFP"].ToString(), Value = reader["IdAFP"] });
                    }
                    cmb_afp.DisplayMember = "Text";
                    cmb_afp.ValueMember = "Value";
                }

                // Cargar Salud
                using (SqlCommand cmd = new SqlCommand("SELECT IdSalud, NombreSalud FROM Salud", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmb_salud.Items.Add("Seleccionar");
                    while (reader.Read())
                    {
                        cmb_salud.Items.Add(new { Text = reader["NombreSalud"].ToString(), Value = reader["IdSalud"] });
                    }
                    cmb_salud.DisplayMember = "Text";
                    cmb_salud.ValueMember = "Value";
                }

                conn.Close();
            }
        }



       

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int horasTrabajadas = int.Parse(tbox_horasTrabajadas.Text);
                int horasExtras = int.Parse(tbox_horasExtras.Text);
                int idAFP = (cmb_afp.SelectedItem as dynamic).Value;
                int idSalud = (cmb_salud.SelectedItem as dynamic).Value;

                // Crear un objeto Empleado ficticio solo para los cálculos
                Empleado empleado = new Empleado
                {
                    ValorHora = 5000, // Cambia esto según tu lógica
                    ValorHoraExtra = 7000, // Cambia esto según tu lógica
                    IdAFP = idAFP,
                    IdSalud = idSalud
                };

                // Calcular el sueldo líquido
                decimal sueldoLiquido = calculoSueldoNegocio.CalcularSueldo(empleado, horasTrabajadas, horasExtras);
                decimal sueldoBruto = (empleado.ValorHora * horasTrabajadas) + (empleado.ValorHoraExtra * horasExtras);

                // Mostrar resultados en los TextBox correspondientes
                tbox_sueldoBruto.Text = sueldoBruto.ToString();
                tbox_sueldoLiquido.Text = sueldoLiquido.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el sueldo: " + ex.Message);
            }
        }

        // Evento click para guardar el empleado en la base de datos
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Empleado (Rut, Nombre, Direccion, Telefono, IdAFP, IdSalud) VALUES (@Rut, @Nombre, @Direccion, @Telefono, @IdAFP, @IdSalud)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Rut", tbox_rutEmpleado.Text);
                        cmd.Parameters.AddWithValue("@Nombre", tbox_nombre.Text);
                        cmd.Parameters.AddWithValue("@Direccion", tbox_direccion.Text);
                        cmd.Parameters.AddWithValue("@Telefono", tbox_telefono.Text);
                        cmd.Parameters.AddWithValue("@IdAFP", (cmb_afp.SelectedItem as dynamic).Value);
                        cmd.Parameters.AddWithValue("@IdSalud", (cmb_salud.SelectedItem as dynamic).Value);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                MessageBox.Show("Empleado guardado exitosamente.");
                btn_limpiarCampos.PerformClick(); // Limpiar campos después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
            }
        }

        private void btn_limpiarCampos_Click(object sender, EventArgs e)
        {
            tbox_rutEmpleado.Clear();
            tbox_nombre.Clear();
            tbox_direccion.Clear();
            tbox_telefono.Clear();
            tbox_horasTrabajadas.Clear();
            tbox_horasExtras.Clear();
            tbox_sueldoBruto.Clear();
            tbox_sueldoLiquido.Clear();
            cmb_afp.SelectedIndex = -1; // Seleccionar "Seleccionar"
            cmb_salud.SelectedIndex = -1; // Seleccionar "Seleccionar"
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListarTrabajadores listarTrabajadoresForm = new ListarTrabajadores();
            listarTrabajadoresForm.Show();
        }
    }
}
