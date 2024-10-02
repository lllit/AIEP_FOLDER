using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; }
        public int IdEmpleado { get; set; }

        // Relación con RolUsuario y Empleado
        public RolUsuario Rol { get; set; }
        public Empleado Empleado { get; set; }
    }
}
