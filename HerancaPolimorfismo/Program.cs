using System;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> listOfProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char selectProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (selectProduct)
                {
                    case 'c':
                        listOfProducts.Add(new Product(name, price));
                        break;

                    case 'u':
                        {
                            Console.Write("Manufacture Date (dd/MM/yyyy) :");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            UsedProduct usedProduct = new UsedProduct(name, price, manufactureDate);
                            listOfProducts.Add(usedProduct);
                            break;
                        }
                    case 'i':
                        {
                            Console.Write("Customs fee: ");
                            double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            ImportedProduct importedProduct = new ImportedProduct(name, price, customFee);
                            listOfProducts.Add(importedProduct);
                            break;
                        }
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product item in listOfProducts)
            {
                Console.WriteLine(item.PriceTag());
            }


        }
    }
}
