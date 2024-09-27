using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgv_principal.Columns.Add("Desde","Desde");
            dgv_principal.Columns.Add("Hasta", "Hasta");
            dgv_principal.Columns.Add("< Numero", "< Numero");
            dgv_principal.Columns.Add("> Numero", "> Numero");
            dgv_principal.Columns.Add("Cantidad", "Cantidad");
            dgv_principal.Columns.Add("Tiempo", "Tiempo (Segundos)");

            // Agregar la columna "Observaciones" como editable
            var columnaObservaciones = new DataGridViewTextBoxColumn
            {
                Name = "Observaciones",
                HeaderText = "Observaciones",
                ReadOnly = false // Permite editar la columna
            };
            dgv_principal.Columns.Add(columnaObservaciones);

            // Configurar el resto de las columnas como solo lectura
            foreach (DataGridViewColumn columna in dgv_principal.Columns)
            {
                if (columna.Name != "Observaciones")
                {
                    columna.ReadOnly = true; // Hacer todas las columnas excepto "Observaciones" de solo lectura
                }
            }

            dgv_principal.Rows.Add("1", "99");
            dgv_principal.Rows.Add("100", "999");
            dgv_principal.Rows.Add("1000", "9999");
            dgv_principal.Rows.Add("10000", "99999");
            dgv_principal.Rows.Add("100000", "999999");
            dgv_principal.Rows.Add("1000000", "1999999");
        }


       
        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            CN_Recursos recursos = new CN_Recursos();


            // Definir los rangos con base en los RadioButtons
            int rangoMin, rangoMax;

            picBox1.Visible = true;

            switch (true)
            {
                case bool _ when rb_1.Checked:
                    rangoMin = 1;
                    rangoMax = 99;
                    break;

                case bool _ when rb_2.Checked:
                    rangoMin = 100;
                    rangoMax = 999;
                    break;

                case bool _ when rb_3.Checked:
                    rangoMin = 1000;
                    rangoMax = 9999;
                    break;

                case bool _ when rb_4.Checked:
                    rangoMin = 10000;
                    rangoMax = 99999;
                    break;

                case bool _ when rb_5.Checked:
                    rangoMin = 100000;
                    rangoMax = 999999;
                    break;

                case bool _ when rb_6.Checked:
                    rangoMin = 1000000;
                    rangoMax = 1999999;
                    break;

                default:
                    picBox1.Visible = false;
                    MessageBox.Show("Selecciona un rango válido.");
                    return;
            }

            // Llamar a la clase CN_Recursos para calcular los resultados
            await Task.Run(() => recursos.CalcularResultados(rangoMin, rangoMax, dgv_principal));

            // Ocultar el GIF de procesamiento
            picBox1.Visible = false;
        }
    }
}
