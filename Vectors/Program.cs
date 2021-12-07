using System;
using System.Globalization;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            
            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Nome = nome, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine(avg);
        }
    }
}
