using System;
using System.Globalization;
using System.Collections.Generic;
using GenericConstraints.Entity;
using GenericConstraints.Service;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProducts = new List<Product>();
            Console.Write("Enter N: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                string[] vct = Console.ReadLine().Split(",");
                string name = vct[0];
                double price = double.Parse(vct[1], CultureInfo.InvariantCulture);

                listOfProducts.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product maxProduct = calculationService.Max(listOfProducts);

            Console.WriteLine("Most Expensive: ");
            Console.WriteLine(maxProduct);
        }
    }
}
