using System;
using GeneticTypes.Entity;

namespace GeneticTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int valuesQuantity = int.Parse(Console.ReadLine());
            for(int i = 0; i < valuesQuantity; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First()); 

        }
    }
}
