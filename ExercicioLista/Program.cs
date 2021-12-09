using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int NumberOfEMployees = int.Parse(Console.ReadLine());
            List<Employee> Employees = new List<Employee>();

            for (int i = 0; i < NumberOfEMployees; i++)
            {
                Console.WriteLine($"Employee {1 + i}: ");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees.Add(new Employee(Id, Name, Salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int IdToIncreaseSalary = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double Percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            foreach (Employee obj in Employees) 
            { 
                obj.IncreaseSalary(IdToIncreaseSalary, Percentage);
                Console.WriteLine(obj);
            }

        }
    }
}
