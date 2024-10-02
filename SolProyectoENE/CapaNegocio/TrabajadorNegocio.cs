using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class TrabajadorNegocio
    {
        private TrabajadorDatos trabajadorDatos = new TrabajadorDatos();

        // Método para calcular el sueldo bruto
        public decimal CalcularSueldoBruto(int horasTrabajadas, int horasExtras, string afp)
        {
            // Se puede aplicar una lógica simple como: horasTrabajadas * tarifa + horasExtras * tarifaExtra
            decimal tarifaHora = 5000; // Ejemplo de tarifa por hora trabajada
            decimal tarifaHoraExtra = 7500; // Ejemplo de tarifa por hora extra

            decimal sueldoBruto = (horasTrabajadas * tarifaHora) + (horasExtras * tarifaHoraExtra);

            // Dependiendo de la AFP, podrías aplicar un descuento o recargo adicional.
            decimal descuentoAfp = trabajadorDatos.ObtenerDescuentoAfp(afp); // Método de capaDatos que obtiene el descuento de AFP
            sueldoBruto -= (sueldoBruto * descuentoAfp); // Aplicar descuento AFP

            return sueldoBruto;
        }

        // Método para calcular el sueldo líquido
        public decimal CalcularSueldoLiquido(decimal sueldoBruto, string salud)
        {
            // Aplicar un descuento por sistema de salud
            decimal descuentoSalud = trabajadorDatos.ObtenerDescuentoSalud(salud); // Método de capaDatos que obtiene el descuento de Salud
            decimal sueldoLiquido = sueldoBruto - (sueldoBruto * descuentoSalud);

            return sueldoLiquido;
        }

        // Método para guardar el trabajador en la base de datos
        //public void GuardarTrabajador(Trabajador trabajador)
        //{
        //    trabajadorDatos.InsertarTrabajador(trabajador); // Llamada a la capa de datos para insertar
        //}

        // Método para obtener todas las AFP desde la base de datos
        public DataTable ObtenerAfp()
        {
            return trabajadorDatos.ObtenerListaAfp(); // Llamada a capaDatos
        }

        // Método para obtener todas las Salud desde la base de datos
        public DataTable ObtenerSalud()
        {
            return trabajadorDatos.ObtenerListaSalud(); // Llamada a capaDatos
        }

        // Método para obtener todos los trabajadores desde la base de datos
        public DataTable ObtenerTodosLosTrabajadores()
        {
            return trabajadorDatos.ObtenerTodosLosTrabajadores(); // Llamada a capaDatos para listar
        }
    }
}
