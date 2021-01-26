using System;

namespace ExecStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //NÃO PRECISA FAZER UMA INSTANCIA POR QUE O TIPO STRUCT É UM TIPO VALOR ELE JÁ RECEBE ALGO NA MEMORIA,
            Point p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);
        }
    }
}
