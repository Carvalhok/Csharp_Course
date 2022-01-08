using System;
using GenericConstraints.Entities;
using GenericConstraints.Services;
using System.Collections.Generic;
using System.Globalization;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter N: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] str = Console.ReadLine().Split(",");
                string name = str[0];
                double price = double.Parse(str[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product p = calculationService.Max(list);
            Console.WriteLine("Max: ");
            Console.WriteLine(p);
        }
    }
}
