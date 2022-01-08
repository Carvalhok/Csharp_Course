using System.Globalization;
using System;

namespace IComparebleExcercise.Entity
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] str = csvEmployee.Split(",");
            Name = str[0];
            Salary = double.Parse(str[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Agumenting error: Argument isn't an Employee type");
            }

            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
