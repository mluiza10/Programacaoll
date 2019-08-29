using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer07
{
    class Historico
    {
        private string aluno;
        int k;
        double y;
        private Disciplina[] discs = new Disciplina[10];

        public void Hist(string aluno)
        {
            this.aluno = aluno;
        }

        public void Inserir (Disciplina d)
        {
            if (k < 10)
            {
                discs[k++] = d;
            }
        }

        public  Disciplina[] Listar()
        {
            Disciplina[] novo = new Disciplina[k];
            Array.Copy(discs, novo, k);
            return novo;
        }
        public void Excluir(int g)
        {
            for(int i = g; i <= k; k++)
            {
                discs[i] = discs[i + 1];
            }
            
            k--;
        }
        /*public double IRA()
        {
            if (k == 0)
            return 0;
     
            foreach (Disciplina d in discs)
                if (d != null )
                 y = y + d.GetMedia();
                return y / k;
        }*/
        
    }
}



