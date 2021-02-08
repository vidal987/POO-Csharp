using ExecClasesAbstrata.Entities;
using System;
using System.Collections.Generic;

namespace ExecClasesAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "ALEX", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "bob", 500.0, 0.01));


        }
    }
}
