using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CalculoSueldoNegocio
    {
        // Método para calcular el sueldo de un empleado
        public decimal CalcularSueldo(Empleado empleado, int horasTrabajadas, int horasExtras)
        {
            // Calculo básico de sueldo
            decimal sueldoBruto = (empleado.ValorHora * horasTrabajadas) + (empleado.ValorHoraExtra * horasExtras);

            // Obtener los descuentos de AFP y Salud
            decimal descuentoAFP = sueldoBruto * ObtenerDescuentoAFP(empleado.IdAFP);
            decimal descuentoSalud = sueldoBruto * ObtenerDescuentoSalud(empleado.IdSalud);

            // Calcular el sueldo líquido
            decimal sueldoLiquido = sueldoBruto - (descuentoAFP + descuentoSalud);

            return sueldoLiquido;
        }

        // Método para obtener el porcentaje de descuento de AFP
        private decimal ObtenerDescuentoAFP(int idAFP)
        {
            switch (idAFP)
            {
                case 1: return 0.07m; // CUPRUM
                case 2: return 0.09m; // MODELO
                case 3: return 0.12m; // CAPITAL
                case 4: return 0.13m; // PROVIDA
                default: return 0.0m;
            }
        }

        // Método para obtener el porcentaje de descuento de Salud
        private decimal ObtenerDescuentoSalud(int idSalud)
        {
            switch (idSalud)
            {
                case 1: return 0.12m; // FONASA
                case 2: return 0.13m; // CONSALUD
                case 3: return 0.14m; // MASVIDA
                case 4: return 0.15m; // BANMEDICA
                default: return 0.0m;
            }
        }
    }
}
