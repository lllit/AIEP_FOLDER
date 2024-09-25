using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parPerfectoPrimo
{
    public class Evaluaciones
    {

        public bool isNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
               
        }

        public bool Par(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool Perfecto(int num)
        {
            int sum = 0;
            for (int i=1; i<num; i++)
            {
                if(num%i == 0)
                {
                    sum++;
                }  
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Primo(int num)
        {
            int cont = 0;
            int i = 1;
            while (i<=num)
            {
                if (num%i == 0)
                {
                    cont++;
                }

                if (cont > 2)
                {
                    i++;
                }
                i++;
            }

            if(cont == 2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
