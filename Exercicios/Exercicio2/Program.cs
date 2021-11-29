using System;
using Exercicio2.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            Console.Write("Enter the number of tax payers: ");
            int numberPayers = int.Parse(Console.ReadLine());
            

            for(int i = 1; i <= numberPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write($"Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(ch == 'i')
                {
                    Console.Write("Health Expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPeople(name, annualIncome, healthExpenditure));

                }

                else
                {
                    Console.Write("Number of Employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    list.Add(new LegalPeople(name, annualIncome, employeeNumber));
                }
            }

            double sum =0;
            Console.WriteLine();
            Console.WriteLine("Tax Paid: ");
            
            foreach(People people in list)
            {
                Console.WriteLine(people.Name + ": $ " + people.TaxPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += people.TaxPaid();
            }

            Console.WriteLine();
            Console.WriteLine("Total Tax Paid: $" + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
