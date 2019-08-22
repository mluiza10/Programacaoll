using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer05
{
    class Numeros
    {
        private int inicio, fim;

        public void SetInicio(int i)
        {
            inicio = i;
        }

        public int GetInicio()
        {
            return inicio;
        }

        public void SetFim(int f)
        {
            fim = f;
        }

        public int GetFim()
        {
            return fim;
        }

        public int[] Calc(bool p, bool t)
        {
            int[] z = new int[fim - inicio + 1];
            int cont = 0;
            for (int x = inicio; x <= fim; x++)
            {
                if (p == true && t == false && x % 2 == 0)
                {
                    z[cont] = x;
                    cont++;
                }

                if (t == true && p == false && x % 2 != 0)
                {
                    z[cont] = x;
                    cont++;
                }

                if (p == true && t == true)
                {
                    z[cont] = x;
                    cont++;
                }
            }
            int[] w = new int[cont];
            Array.Copy(z, w, cont);
            return w;
        }
    }
}

