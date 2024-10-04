using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CalculoSueldo
    {
        public int IdCalculo { get; set; }
        public int IdEmpleado { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtras { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal DescuentoAFP { get; set; }
        public decimal DescuentoSalud { get; set; }
        public decimal SueldoLiquido { get; set; }
        public DateTime FechaCalculo { get; set; }

        // Relación con Empleado
        public Empleado Empleado { get; set; }
    }
}
