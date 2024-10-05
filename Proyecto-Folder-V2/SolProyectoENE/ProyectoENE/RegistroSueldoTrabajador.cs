using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using static System.Net.Mime.MediaTypeNames;


namespace ProyectoENE
{
    public partial class RegistroSueldoTrabajador : Form
    {
        

        private Conexion conexion;
        private CalculoSueldoNegocio calculoSueldoNegocio;
        private CN_Recursos recursosNegocio;
        private Empleado empleado;
        private Usuario usuario; // Añadimos la instancia de Usuario
        // Crear una instancia de UsuarioNegocio
        UsuarioNegocio negocio = new UsuarioNegocio();
        EmpleadoNegocio oEmpleadoNegocio = new EmpleadoNegocio();
        

        public RegistroSueldoTrabajador(Empleado empleado, Usuario usuario)
        {
            InitializeComponent();

            this.empleado = empleado;
            this.usuario = usuario; // Inicializamos el usuario

            if (usuario.IdRol == 1 || usuario == null)
            {
                //Es admin
                tbox_rutEmpleado.Enabled = true;
                tbox_direccion.Enabled = true;
                tbox_telefono.Enabled = true;
                btn_guardar.Enabled = true;
                btn_listar.Enabled = true;
                btn_limpiarCampos.Enabled = true;
                cmb_afp.Enabled = true;
                cmb_salud.Enabled = true;

            }
            else
            {
                
                // Es usuario normal
                tbox_rutEmpleado.Enabled = false;
                tbox_nombre.Enabled = false;
                tbox_direccion.Enabled = false;
                tbox_telefono.Enabled = false;
                btn_guardar.Enabled = false;
                btn_listar.Enabled = false;
                btn_limpiarCampos.Enabled = false;
                cmb_afp.Enabled = false;
                cmb_salud.Enabled = false;
            }

        }

        
        private void RegistroSueldoTrabajador_Load(object sender, EventArgs e)
        {

            
            conexion = new Conexion();
            calculoSueldoNegocio = new CalculoSueldoNegocio();


            CargarDatosComboBoxes();
            CargarDatosEmpleado(); // Cargamos los datos del empleado al formulario
        }

        // Método para validar el acceso del usuario
        private void ValidarAccesoUsuario()
        {
            if (negocio.EsAdmin(usuario))
            {
                // Si el usuario es administrador, permitimos acceso completo
                MessageBox.Show("Acceso de administrador.");
            }
            else if (negocio.EsUsuarioNormal(usuario))
            {
                // Si es un usuario normal, restringimos ciertas funciones
                MessageBox.Show("Acceso de usuario normal. Algunas funciones están restringidas.");
                btn_guardar.Enabled = false; // Por ejemplo, deshabilitamos la opción de guardar
            }
            else
            {
                // Si no es ni admin ni usuario normal, denegamos acceso
                MessageBox.Show("Acceso denegado. Usuario sin permisos.");
                this.Close(); // Cerramos el formulario
            }
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
                    cmb_afp.Items.Clear();  // Limpiar ítems previos
                    cmb_afp.Items.Add(new ComboBoxItem { Text = "Seleccionar", Value = 0 });  // Ítem por defecto

                    while (reader.Read())
                    {
                        cmb_afp.Items.Add(new ComboBoxItem
                        {
                            Text = reader["NombreAFP"].ToString(),
                            Value = Convert.ToInt32(reader["IdAFP"])
                        });
                    }
                }

                // Cargar Salud
                using (SqlCommand cmd = new SqlCommand("SELECT IdSalud, NombreSalud FROM Salud", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmb_salud.Items.Clear();  // Limpiar ítems previos
                    cmb_salud.Items.Add(new ComboBoxItem { Text = "Seleccionar", Value = 0 });  // Ítem por defecto

                    while (reader.Read())
                    {
                        cmb_salud.Items.Add(new ComboBoxItem
                        {
                            Text = reader["NombreSalud"].ToString(),
                            Value = Convert.ToInt32(reader["IdSalud"])
                        });
                    }
                }

                conn.Close();
            }
        }


        private void CargarDatosEmpleado()
        {
            if (empleado != null)
            {
                tbox_rutEmpleado.Text = empleado.Rut;
                tbox_nombre.Text = empleado.Nombre;
                tbox_direccion.Text = empleado.Direccion;
                tbox_telefono.Text = empleado.Telefono;

                
                // Seleccionar AFP
                cmb_afp.SelectedItem = cmb_afp.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Value == empleado.IdAFP);

                // Seleccionar Salud
                cmb_salud.SelectedItem = cmb_salud.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Value == empleado.IdSalud);
            }
        }


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                List<Empleado> oLista = oEmpleadoNegocio.ListarEmpleados();
                

                int horasTrabajadas = int.Parse(tbox_horasTrabajadas.Text);
                int horasExtras = int.Parse(tbox_horasExtras.Text);
                int idAFP = (cmb_afp.SelectedItem as dynamic).Value;
                int idSalud = (cmb_salud.SelectedItem as dynamic).Value;
                Empleado oEmpleado = oLista.FirstOrDefault(emp => emp.IdEmpleado == empleado.IdEmpleado);


                decimal valorHora = oEmpleado.ValorHora;
                decimal valorHoraExtra = oEmpleado.ValorHoraExtra;


                

                // Calcular el sueldo líquido
                decimal sueldoLiquido = calculoSueldoNegocio.CalcularSueldo(oEmpleado, horasTrabajadas, horasExtras);
                decimal sueldoBruto = (valorHora * horasTrabajadas) + (valorHoraExtra * horasExtras);



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
                // Crear instancia de Empleado con los datos del formulario
                Empleado empleado = new Empleado
                {
                    Rut = tbox_rutEmpleado.Text,
                    Nombre = tbox_nombre.Text,
                    Direccion = tbox_direccion.Text,
                    Telefono = tbox_telefono.Text,
                    IdAFP = (cmb_afp.SelectedItem as ComboBoxItem).Value,
                    IdSalud = (cmb_salud.SelectedItem as ComboBoxItem).Value,
                    ValorHora = 5000, // Ajustar según necesidad, si es necesario un valor fijo
                    ValorHoraExtra = 7000 // Ajustar según necesidad, si es necesario un valor fijo
                };

                int horasTrabajadas = int.Parse(tbox_horasTrabajadas.Text); // Obtener horas trabajadas del formulario
                int horasExtras = int.Parse(tbox_horasExtras.Text); // Obtener horas extras del formulario


                //ENVIAR DATOS A LA TABLA CALCULO SUELDO

                // Guardar el empleado a través de EmpleadoNegocio
                if (oEmpleadoNegocio.guardarEmpleado(empleado, horasTrabajadas,horasExtras))
                {
                    MessageBox.Show("Empleado guardado exitosamente.");
                    btn_limpiarCampos.PerformClick(); // Limpiar campos después de guardar
                }

                //MessageBox.Show("Empleado guardado exitosamente.");
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
