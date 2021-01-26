using System;
using System.Globalization;

namespace ExecEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("tv", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());


        }
    }
}
