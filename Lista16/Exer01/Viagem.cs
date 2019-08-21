using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer01
{
    class Viagem
    {
        private double distancia;
        public void SetDistancia(double d) { distancia = d; }
        public double GetDistancia() { return distancia; }
        private double tempo;
        public void SetTempo(double t) { tempo = t; }
        public double GetTempo() { return tempo; }
        public double CalcVelocidade() { return distancia / tempo; }
    }
}
