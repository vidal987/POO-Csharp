using System;

namespace ExecNullable
{
    class Program
    {
        static void Main(string[] args)
        {//??? DEIXA A VARIAVEL DE VALOR COMO OPSIONAL
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 6;

        }
    }
}
