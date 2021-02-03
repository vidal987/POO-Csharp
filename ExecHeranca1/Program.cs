﻿using ExecHeranca1.Entities;
using System;

namespace ExecHeranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "MARIA", 0.0, 500.0);

            ////UPCASTING Conversao da classe para super classe

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            ////BusinessAccount acc5 = (BusinessAccount)acc3;
            //if (acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;

            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("loan !");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("update");
            //}

            Account acc = new Account(1001, "Alex", 500.0);
            Account acc1 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc.Withdraw(10.0);
            acc1.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc1.Balance);

        }
    }
}
