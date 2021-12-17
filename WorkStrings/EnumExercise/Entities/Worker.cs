using System;
using System.Collections.Generic;
using System.Text;
using EnumExercise.Entities.Enum;


namespace EnumExercise.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double TotalIncome = BaseSalary;

            foreach(HourContract obj in Contracts)
            {
                if(obj.Date.Month == month && obj.Date.Year == year)
                {
                    TotalIncome += obj.totalValue();
                }
            }
            return TotalIncome;
        }
    }
}
