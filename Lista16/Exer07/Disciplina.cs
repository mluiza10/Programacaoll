using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer07
{
    class Disciplina
    {
        private string nome;
        private string semestre;
        private int media;
        private bool aprovado;

        public Disciplina(string nome, int media, string semestre, bool aprovado)
        {
            this.nome = nome;
            this.media = media;
            this.semestre = semestre;
            this.aprovado = aprovado;
        }
       
        public override string ToString() // serve para  imprimir no list
        {
            return $"{nome} - {semestre} - {media}";
        }

        public double GetMedia()
        {
            return media;
        }

    }
}
