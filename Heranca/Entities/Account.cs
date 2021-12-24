using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            if(amount <= Balance)
                Balance += amount;

            else
                Console.WriteLine("Something goes wrong");
        }

    }
}

