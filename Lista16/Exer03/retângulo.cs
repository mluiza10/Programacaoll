using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer03
{
    class retângulo
    {
        private double Base;
        public void SetBase(double b) { Base = b; }
        public double GetBase() { return Base; }

        private double Altura;
        public void SetAltura(double a) { Altura = a; }
        public double GetAltura() { return Altura; }

        public double CalcArea() { return Base * Altura; }
        public double CalcDiagonal() { return Math.Sqrt((Base * Base) + (Altura * Altura)); }


     
    }
}
