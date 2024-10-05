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
        private Empleado empleado;
        TrabajadorNegocio oTrabajador = new TrabajadorNegocio();
        private Usuario usuario; // Añadimos la instancia de Usuario
        //private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
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

        //Cargar en el ComboBox
        private void CargarEmpleados()
        {
            var empleados = _usuarioNegocio.ObtenerTodosLosEmpleados();
            cmb_trabajador.DataSource = empleados;
            cmb_trabajador.DisplayMember = "Nombre";
            cmb_trabajador.ValueMember = "IdEmpleado";
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
                //decimal sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;
                decimal? sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);
                // Añadir la fila al DataGridView
                dgv_trabajador.Rows.Add(empleadoFiltrado.Rut, empleadoFiltrado.Nombre, empleadoFiltrado.Direccion, sueldoLiquido);
            }
        }


        




        private decimal ObtenerTasaAFP(int idAFP)
        {
            // Este método debería obtener la tasa de descuento desde la base de datos
            // Por ahora, se puede simular con valores fijos o realizar una consulta
            switch (idAFP)
            {
                case 1: return 7.00m;
                case 2: return 9.00m;
                case 3: return 12.00m;
                case 4: return 13.00m;
                default: return 0.00m;
            }
        }

        private decimal ObtenerTasaSalud(int idSalud)
        {
            // Este método debería obtener la tasa de descuento desde la base de datos
            // Por ahora, se puede simular con valores fijos o realizar una consulta
            switch (idSalud)
            {
                case 1: return 12.00m;
                case 2: return 13.00m;
                case 3: return 14.00m;
                case 4: return 15.00m;
                default: return 0.00m;
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











        private void MostrarDatosEnDataGridView(int idEmpleado)
        {
            List<Empleado> oLista = oEmpleadoNegocio.ListarEmpleados();

            Empleado oEmpleado = oLista.FirstOrDefault(emp => emp.IdEmpleado == idEmpleado);

            decimal valorHora = oEmpleado.ValorHora;
            decimal valorHoraExtra = oEmpleado.ValorHoraExtra;

            var empleado = _usuarioNegocio.ObtenerEmpleadoPorId(idEmpleado);


            //oTrabajador.ObtenerAfp();

            if (empleado != null)
            {
                // Obtener el sueldo líquido desde la base de datos
                decimal? sueldoLiquido = calculoSueldoNegocio.ObtenerSueldoLiquidoPorIdEmpleado(idEmpleado);

                if (sueldoLiquido.HasValue)
                {
                    dgv_trabajador.Rows.Clear();
                    dgv_trabajador.Rows.Add(oEmpleado.Rut, oEmpleado.Nombre, oEmpleado.Direccion, sueldoLiquido.Value);
                }
                else
                {
                    MessageBox.Show("No se encontró el sueldo líquido para el empleado especificado.");
                }


                // Aquí debes calcular el sueldo líquido a partir del sueldo bruto y descuentos
                //decimal sueldoBruto = (empleado.ValorHora * 160) + (empleado.ValorHoraExtra * 20); // Ejemplo con horas rabajadasfijas
                //decimal descuentoAFP = sueldoBruto * ObtenerTasaAFP(empleado.IdAFP) / 100;
                //decimal descuentoSalud = sueldoBruto * ObtenerTasaSalud(empleado.IdSalud) / 100;
                //decimal sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;

                //dgv_trabajador.Rows.Clear();
                //dgv_trabajador.Rows.Add(empleado.Rut, empleado.Nombre, empleado.Direccion, sueldoLiquido);
            }
        }


    }
}
