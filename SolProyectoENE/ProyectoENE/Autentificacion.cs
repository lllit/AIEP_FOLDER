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
                    // Verificamos si el usuario es administrador
                    if (usuarioValidado.IdRol == 1) // 1 = Administrador
                    {
                        MessageBox.Show("Bienvenido Administrador");

                        // Redirigimos al formulario RegistroSueldoTrabajador
                        RegistroSueldoTrabajador registroForm = new RegistroSueldoTrabajador();
                        registroForm.Show();
                        this.Hide(); // Ocultamos el formulario actual
                    }
                    else
                    {
                        MessageBox.Show("Usuario normal, acceso denegado.");
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
    }
}
