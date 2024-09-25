using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parPerfectoPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            Evaluaciones obj = new Evaluaciones();

            if (!obj.isNumeric(tbx_numero.Text))
            {
                lbl_errores.Text = "Ingrese un valor entero..";
            } else
            {
                lbl_errores.Text = "";

                //PAR
                bool res1 = obj.Par(Convert.ToInt32(tbx_numero.Text));
                lbl_res_par.Text = Convert.ToString(res1);
                //PERFECTO
                bool res2 = obj.Perfecto(Convert.ToInt32(tbx_numero.Text));
                lbl_res_perfecto.Text = Convert.ToString(res2);
                //PRIMO
                bool res3 = obj.Primo(Convert.ToInt32(tbx_numero.Text));
                lbl_res_primo.Text = Convert.ToString(res3);

            }
        }
    }
}
