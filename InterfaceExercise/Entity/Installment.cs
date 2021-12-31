using System;
using System.Globalization;

namespace InterfaceExercise.Entity
{
    class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
