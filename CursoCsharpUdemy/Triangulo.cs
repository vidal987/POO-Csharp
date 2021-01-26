
using System;

namespace CursoCsharpUdemy
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        //MÉTODO DE EXECUÇÃO DO CALCULO DE AREA
        public double Area()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }
    }
}
