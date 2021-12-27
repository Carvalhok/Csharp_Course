using System;
using System.Collections.Generic;
using Section10Exercise.Entites;
using System.Globalization;

namespace Section10Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> payer = new List<Taxpayer>();
            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());
            double totalTax = 0;
            
            for( int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or Company (i/c)");
                char selector = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch(selector){

                    case 'i':
                        {
                            Console.Write("Health Expenditure: ");
                            double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            payer.Add(new PhysicalPerson(name, annualIncome, healthExpenditure));
                            break;
                        }

                    case 'c':
                        {
                            Console.Write("Number of Employees: ");
                            int numberOfEmployees = int.Parse(Console.ReadLine());
                            payer.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                            break;
                        }

                }

            }

            Console.WriteLine();
            Console.WriteLine("TAX PAID: ");

            foreach (Taxpayer taxpayer in payer)
            {
                Console.WriteLine(taxpayer.Nome + ": $ " + taxpayer.TaxToPay().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += taxpayer.TaxToPay();
            }

            Console.WriteLine("Tatal Taxes: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
