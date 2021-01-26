using System;

namespace ExecClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pessoa  Pessoa1, Pessoa2;

            //Pessoa1 = new Pessoa();
            //Pessoa2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Digite seu nome: ");
            //Pessoa1.Nome = Console.ReadLine();
            //Console.Write("Digite sua idade: ");
            //Pessoa1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Digite seu nome: ");
            //Pessoa2.Nome = Console.ReadLine();
            //Console.Write("Digite sua idade: ");
            //Pessoa2.Idade = int.Parse(Console.ReadLine());

            //if (Pessoa1.Idade > Pessoa2.Idade )
            //{
            //    Console.WriteLine($"Pessoa mais velha: {Pessoa1.Nome} ");
            //}
            //else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {Pessoa2.Nome} ");
            //}

            Funcionario Func1, Func2;

            Func1 = new Funcionario();
            Func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Digite o nome: ");
            Func1.Nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            Func1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Digite o nome: ");
            Func2.Nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            Func2.Salario = double.Parse(Console.ReadLine());

            double mediaSalario = (Func1.Salario + Func2.Salario) / 2;

            Console.WriteLine($"Salário médio = {mediaSalario}");
        }
    }
}
