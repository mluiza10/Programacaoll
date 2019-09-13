using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer06
{
    class Bingo
    {
        private int numBolas;
        private int[] v;
        private int c;
        public void Iniciar(int numBolas)
        {
            this.numBolas = numBolas;
            int k = 0;
            int[] v = new int[numBolas];
            Random r = new Random();
            while (k < numBolas)
            {
                int n = r.Next(1, numBolas + 1);
                if (Array.IndexOf(v, n) == -1{
                    v[k] = n; k++;
                }
            }
        
        }
        public int Proximo()
        {
            if (c < numBolas)
            {
                int x = v[c];
                c++;
                return x;
            }

    }
}
