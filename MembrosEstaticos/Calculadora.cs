using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{

    //Membro estatico n é variavel, pode ser usado varias vezes retorna o mesmo resultado 
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
