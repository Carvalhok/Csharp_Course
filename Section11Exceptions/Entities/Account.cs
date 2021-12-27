using Section11Exceptions.Entities.Exceptions;
using System.Globalization;

namespace Section11Exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 50.00)
            {
                throw new DomainException("Tha balance amount must be at least 50 Dolars");
            }

            else
            {
                Number = number;
                Holder = holder;
                Balance = balance;
                WithdrawLimit = withdrawLimit;
            }
        }

        public void Deposit(double amount)
        {
            Balance = +amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new DomainException("Not enough balance!");

            if (amount > WithdrawLimit)
                throw new DomainException("The amount exceeds withdraw limit");
            else
                Balance -= amount;
        }

        public override string ToString()
        {
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
