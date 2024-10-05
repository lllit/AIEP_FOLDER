using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class validarErrorProvider : Form
    {
        public validarErrorProvider()
        {
            InitializeComponent();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            if (tbox_valor.Text.Length == 0)
            {
                errorProvider1.SetError(tbox_valor, "Ingrese un valor!");
            }
            else
            {
                errorProvider1.SetError(tbox_valor,"");
            }
        }
    }
}
