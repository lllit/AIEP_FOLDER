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
            //CargarEmpleados();
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
                //MostrarDatosEnDataGridView(empleado.IdEmpleado);
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

                //MessageBox.Show($"Valor hora es: {empleadoFiltrado.ValorHora.ToString()}");


                // Limpiar DataGridView antes de agregar datos
                dgv_trabajador.Rows.Clear();



                if (empleadoFiltrado != null)
                {
                    // Calcular sueldo líquido

                    decimal? sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);
                    // Añadir la fila al DataGridView
                    dgv_trabajador.Rows.Add(empleadoFiltrado.Rut, empleadoFiltrado.Nombre, empleadoFiltrado.Direccion, sueldoLiquido);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al filtrar trabajador: " + ex.Message);
            }
            
        }


        private void CargarTrabajadoresEnComboBox()
        {
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
        private void CargarTodosLosTrabajadoresEnDataGridView()
        {
            // Obtener todos los empleados
            List<Empleado> empleados = _usuarioNegocio.ObtenerTodosLosEmpleados();

            // Limpiar DataGridView antes de agregar datos
            dgv_trabajador.Rows.Clear();

            

            // Añadir empleados al DataGridView
            foreach (var empleado in empleados)
            {
                // Calcular sueldo bruto (esto es solo un ejemplo)
                decimal sueldoBruto = (empleado.ValorHora * 160) + (empleado.ValorHoraExtra * 20); // Suponiendo 160 horas normales y 20 horas extras

                // Ejemplo de cálculo de descuentos (estos porcentajes deben ser ajustados según la lógica de negocio)
                decimal descuentoAFP = sueldoBruto * 0.1m; // 10% de descuento para AFP
                decimal descuentoSalud = sueldoBruto * 0.07m; // 7% de descuento para Salud

                int idEmpleado = empleado.IdEmpleado;

                // Calcular sueldo líquido
                //decimal sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;

                decimal? sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);


                // Añadir la fila al DataGridView
                dgv_trabajador.Rows.Add(empleado.Rut, empleado.Nombre, empleado.Direccion, sueldoLiquido);
            }
        }

        
        
        private void btn_volver_Click(object sender, EventArgs e)
        {

            this.Hide();
        }



    }
}
