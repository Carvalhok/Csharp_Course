using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 500.00, 500.0);
            SavingsAccount sacc = new SavingsAccount(1010, "Keverson", 500.00, 0.01);

            bacc.Withdraw(100);
            sacc.Withdraw(100);

            Console.WriteLine(bacc.Balance);
            Console.WriteLine(sacc.Balance);

        }
    }
}
