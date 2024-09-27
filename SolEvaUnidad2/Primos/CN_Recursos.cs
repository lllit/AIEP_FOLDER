using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public class CN_Recursos
    {

        public void CalcularResultados(int rangoMin, int rangoMax, DataGridView dgv)
        {
            Stopwatch cronos = new Stopwatch();

           
            // Función para verificar si un número es primo
            bool EsPrimo(int numero)
            {
                if (numero <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(numero); i++) //Math.Sqrt devuelve la raiz cuadrada de un numero especificado
                {
                    if (numero % i == 0)
                        return false;
                }
                return true;
            }

            // 1. Calcular el número primo más pequeño en el rango
            cronos.Start();
            int primoMasPequeno = Enumerable.Range(rangoMin, rangoMax - rangoMin + 1).FirstOrDefault(EsPrimo);
            cronos.Stop();
            TimeSpan tiempoPrimoPequeno = cronos.Elapsed;

            // 2. Calcular el número primo mayor en el rango
            cronos.Restart();
            int primoMayor = Enumerable.Range(rangoMin, rangoMax - rangoMin + 1).LastOrDefault(EsPrimo);
            cronos.Stop();
            TimeSpan tiempoPrimoMayor = cronos.Elapsed;

            // 3. Calcular la cantidad total de números primos en el rango
            cronos.Restart();
            int cantidadPrimos = Enumerable.Range(rangoMin, rangoMax - rangoMin + 1).Count(EsPrimo);
            cronos.Stop();
            TimeSpan tiempoCantidadPrimos = cronos.Elapsed;

            // Calcular el tiempo total de todos los procesos
            double tiempoTotal = tiempoPrimoPequeno.TotalSeconds + tiempoPrimoMayor.TotalSeconds + tiempoCantidadPrimos.TotalSeconds;

            // Buscar si ya existe una fila con el rango actual
            bool filaExistente = false;
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["Desde"].Value != null &&
                    int.TryParse(fila.Cells["Desde"].Value.ToString(), out int desde) &&
                    int.TryParse(fila.Cells["Hasta"].Value.ToString(), out int hasta) &&
                    desde == rangoMin && hasta == rangoMax)
                {
                    // Actualizar la fila existente con los resultados
                    fila.Cells["< Numero"].Value = primoMasPequeno;
                    fila.Cells["> Numero"].Value = primoMayor;
                    fila.Cells["Cantidad"].Value = cantidadPrimos;
                    fila.Cells["Tiempo"].Value = tiempoTotal;
                    fila.Cells["Observaciones"].Value = ""; // Puedes agregar lógica para observaciones
                    filaExistente = true;
                    break;
                }
            }

            // Si no existe una fila, agregar una nueva
            if (!filaExistente)
            {
                dgv.Rows.Add(
                    rangoMin,          // "Desde"
                    rangoMax,          // "Hasta"
                    primoMasPequeno,   // "< Numero" (número primo más pequeño)
                    primoMayor,        // "> Numero" (número primo mayor)
                    cantidadPrimos,    // "Cantidad" (cantidad total de números primos)
                    tiempoTotal,       // "Tiempo" (tiempo total de los cálculos en ms)
                    ""                 // "Observaciones" (puedes agregar más lógica aquí si es necesario)
                );
            }

        }


    }
}
