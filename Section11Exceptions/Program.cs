using System;
using System.Globalization;
using Section11Exceptions.Entities.Exceptions;
using Section11Exceptions.Entities;

namespace Section11Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialbalance, limit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.Write("New balance: ");
                Console.WriteLine(account);

            }

            catch (DomainException e)
            {
                Console.WriteLine("Account Creation Failed: " + e.Message);
            }

            catch (Exception e )
            {
                Console.WriteLine("Account Creation failed: " + e.Message);
            }
        }
    }
}
