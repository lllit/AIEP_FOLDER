using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal ValorHora { get; set; }
        public decimal ValorHoraExtra { get; set; }
        public int IdAFP { get; set; }
        public int IdSalud { get; set; }

    }
}
