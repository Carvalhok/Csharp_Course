using System;
using System.IO;
using System.Collections.Generic;
using IComparebleExcercise.Entity;

namespace IComparebleExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string originPath = @"C:\Users\keverson.carvalho\Desktop\Keverson\Csharp_Course\IComparebleExcercise\File1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(originPath))
                {
                    List<Employee> listOfEmployee = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        listOfEmployee.Add(new Employee(sr.ReadLine()));
                    }

                    listOfEmployee.Sort();
                    foreach (Employee emp in listOfEmployee)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Something goes wrong: " + e.Message);
            }

            catch (Exception)
            {
                Console.WriteLine("Somthing goes Wrong");
            }
        }
    }
}
