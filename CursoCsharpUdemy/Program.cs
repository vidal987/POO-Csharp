using System;
using System.Globalization;

namespace CursoCsharpUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do trinagulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do trinagulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p- xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Área de x =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área : X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área : Y");
            //}

            



            /*
             ORIENTAÇÃO A OBJETOS
             */

            //Definindo tipo da variavel, do tipo triangulo == CLASSE
            Triangulo x, y;


            // Instancia da classe nas variaveiss
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do trinagulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trinagulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //EXECUCAO DE CALCULO DE METODO
            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de x =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área : X");
            }
            else
            {
                Console.WriteLine("Maior área : Y");
            }


        }
    }
}
