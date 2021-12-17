using System;
using EnumExercise.Entities.Enum;
using EnumExercise.Entities;
using System.Globalization;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Department's name: ");
            Department dptName = new Department(Console.ReadLine());

            Console.WriteLine("Enter the work data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(workerName, level, salary, dptName);

            Console.WriteLine("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int duration = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(dateContract, valuePerHour, duration));
                
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departmente: " + worker.Department.Name);
            Console.WriteLine("Income for" + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
