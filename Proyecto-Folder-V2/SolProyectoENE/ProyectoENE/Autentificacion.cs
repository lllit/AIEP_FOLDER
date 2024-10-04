using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio; // Asegúrate de agregar la referencia a la capa de negocio
using CapaDatos;  // Para poder usar las entidades

namespace ProyectoENE
{
    public partial class Autentificacion : Form
    {
        // Instanciamos la clase de negocio que maneja la lógica de usuarios
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private Usuario usuario; // Añadimos la instancia de Usuario
        

        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            // Recuperamos los valores de los textboxes
            string nombreUsuario = tbox_usuario.Text;
            string contraseña = tbox_contraseña.Text;

            try
            {
                // Llamamos al método de la capa de negocio para validar usuario
                Usuario usuarioValidado = usuarioNegocio.ValidarUsuario(nombreUsuario, contraseña);

                if (usuarioValidado != null)
                {
                    usuario = usuarioValidado;
                    // Verificamos si el usuario es administrador
                    if (usuarioValidado.IdRol == 1) // 1 = Administrador
                    {
                        MessageBox.Show("Bienvenido Administrador");
                        Empleado empleado = usuarioNegocio.ObtenerEmpleadoPorId(usuarioValidado.IdEmpleado);
                        // Redirigimos al formulario RegistroSueldoTrabajador
                        RegistroSueldoTrabajador registroForm = new RegistroSueldoTrabajador(empleado,usuario);
                        registroForm.Show();
                        this.Hide(); // Ocultamos el formulario actual
                    }
                    else
                    {
                        // Cargar datos del empleado para UsuarioNormal
                        Empleado empleado = usuarioNegocio.ObtenerEmpleadoPorId(usuarioValidado.IdEmpleado);

                        if (empleado != null)
                        {
                            MessageBox.Show("Bienvenido Usuario Normal");

                            // Redirigimos al formulario RegistroSueldoTrabajador con datos de empleado
                            RegistroSueldoTrabajador registroForm = new RegistroSueldoTrabajador(empleado, usuario);
                            registroForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: No se pudo obtener los datos del empleado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message);
            }
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
