using System;
using System.IO;
using WorkingWithFiles.Entity;
using System.Collections.Generic;
using System.Globalization;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\keverson.carvalho\Desktop\Keverson\Csharp_Course\WorkingWithFiles\File1.csv";
            string targetPath = @"C:\Users\keverson.carvalho\Desktop\Keverson\Csharp_Course\WorkingWithFiles\File2.csv";

            try
            {
                string[] productCaracteristics = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string field in productCaracteristics)
                    {
                        string[] fields = field.Split(",");
                        string name = fields[0];
                        double valor = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int amount = int.Parse(fields[2]);

                        Product product = new Product(name, valor, amount);
                        sw.WriteLine(product.Name + ", " + product.TotalValor().ToString("F2", CultureInfo.InvariantCulture));
                    }

                }
            }

            catch(IOException e)
            {
                Console.WriteLine("Something goes wrong: " + e.Message);
            }

        }
    }
}
