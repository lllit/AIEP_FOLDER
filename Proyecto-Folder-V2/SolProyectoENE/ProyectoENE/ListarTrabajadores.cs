using CapaDatos;
using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoENE
{
    public partial class ListarTrabajadores : Form
    {
        private UsuarioNegocio _usuarioNegocio;
        EmpleadoNegocio oEmpleadoNegocio = new EmpleadoNegocio();
        private CalculoSueldoNegocio calculoSueldoNegocio = new CalculoSueldoNegocio();


        public ListarTrabajadores()
        {
            InitializeComponent();
            _usuarioNegocio = new UsuarioNegocio();
            
        }

        private void ListarTrabajadores_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox y DataGridView al cargar el formulario
            CargarTrabajadoresEnComboBox();
            CargarTodosLosTrabajadoresEnDataGridView();
        }

        
        private void cmb_trabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_trabajador.SelectedItem.ToString() == "TODOS")
            {
                // Mostrar todos los trabajadores
                CargarTodosLosTrabajadoresEnDataGridView();
            }
            else
            {
                // Filtrar por el trabajador seleccionado
                FiltrarTrabajadorEnDataGridView(cmb_trabajador.SelectedItem.ToString());
                
            }
        }

        private void FiltrarTrabajadorEnDataGridView(string nombreTrabajador)
        {

            try
            {
                // Obtener todos los empleados
                List<Empleado> empleados = _usuarioNegocio.ObtenerTodosLosEmpleados();

                List<Empleado> oLista = oEmpleadoNegocio.ListarEmpleados();

                // Filtrar por el nombre del trabajador seleccionado
                Empleado empleadoFiltrado = empleados.FirstOrDefault(e => e.Nombre == nombreTrabajador);

                int idEmpleado = empleadoFiltrado.IdEmpleado;

                


                // Limpiar DataGridView antes de agregar datos
                dgv_trabajador.Rows.Clear();



                if (empleadoFiltrado != null)
                {
                    // Calcular sueldo líquido

                    decimal sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);
                    // Añadir la fila al DataGridView
                    dgv_trabajador.Rows.Add(empleadoFiltrado.IdEmpleado,empleadoFiltrado.Rut, empleadoFiltrado.Nombre, empleadoFiltrado.Direccion,empleadoFiltrado.Telefono, sueldoLiquido.ToString("N2"));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al filtrar trabajador: " + ex.Message);
            }
            
        }


        private void CargarTrabajadoresEnComboBox()
        {
            try
            {
                cmb_trabajador.Items.Clear();
                
                // Obtener todos los empleados
                List<Empleado> empleados = _usuarioNegocio.ObtenerTodosLosEmpleados();

                // Agregar opción "TODOS" al combo box
                cmb_trabajador.Items.Add("TODOS");

                // Llenar ComboBox con los nombres de los empleados
                foreach (var empleado in empleados)
                {
                    cmb_trabajador.Items.Add(empleado.Nombre);
                }

                // Establecer el valor por defecto como "TODOS"
                cmb_trabajador.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

       

        private void CargarTodosLosTrabajadoresEnDataGridView()
        {
            try
            {
                // Obtener todos los empleados
                List<Empleado> empleados = _usuarioNegocio.ObtenerTodosLosEmpleados();

                // Limpiar DataGridView antes de agregar datos
                dgv_trabajador.Rows.Clear();

                // Verificar si las columnas ya existen, si no, agregarlas
                if (dgv_trabajador.Columns.Count == 0)
                {
                    // Agregar columnas necesarias al DataGridView
                    dgv_trabajador.Columns.Add("IdEmpleado", "ID Empleado");
                    dgv_trabajador.Columns.Add("Rut", "Rut");
                    dgv_trabajador.Columns.Add("Nombre", "Nombre");
                    dgv_trabajador.Columns.Add("Direccion", "Dirección");
                    dgv_trabajador.Columns.Add("Telefono", "Teléfono");
                    dgv_trabajador.Columns.Add("SueldoLiquido", "Sueldo Líquido");

                    // Ocultar la columna IdEmpleado
                    dgv_trabajador.Columns["IdEmpleado"].Visible = false;
                }


                // Añadir empleados al DataGridView
                foreach (var empleado in empleados)
                {
                    
                    int idEmpleado = empleado.IdEmpleado;


                    decimal sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);


                    // Añadir la fila al DataGridView
                    dgv_trabajador.Rows.Add(idEmpleado, empleado.Rut, empleado.Nombre, empleado.Direccion,empleado.Telefono, sueldoLiquido.ToString("N2"));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        
        
        private void btn_volver_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow fila in dgv_trabajador.Rows)
                {
                    // Verificar que la fila no sea nueva o esté vacía
                    if (fila.IsNewRow || fila.Cells["IdEmpleado"].Value == null)
                        continue;
                    
                    // Crear un objeto Empleado con los datos modificados en el DataGridView
                    Empleado empleadoModificado = new Empleado
                    {
                        IdEmpleado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value), // Obtener el IdEmpleado de la celda
                        Rut = fila.Cells["Rut"].Value.ToString(),
                        Nombre = fila.Cells["Nombre"].Value.ToString(),
                        Direccion = fila.Cells["Direccion"].Value.ToString(),
                        Telefono = fila.Cells["Telefono"].Value.ToString()
                    };
                    

                    // Llama al método de negocio para actualizar el empleado en la base de datos
                    bool actualizado = oEmpleadoNegocio.ActualizarEmpleado(empleadoModificado);

                    if (!actualizado)
                    {
                        // Si no se pudo actualizar, mostrar un mensaje y detener el proceso
                        MessageBox.Show($"Error al actualizar el empleado con ID: {empleadoModificado.IdEmpleado}");
                        return;
                    }
                }
                // Si se actualizan todos los empleados, mostrar un mensaje de éxito
                MessageBox.Show("Todos los empleados han sido actualizados correctamente.");
                CargarTrabajadoresEnComboBox();
                CargarTodosLosTrabajadoresEnDataGridView();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }


        }

       
        
        
        private void dgv_trabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
