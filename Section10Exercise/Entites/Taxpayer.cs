using System;
using System.Collections.Generic;
using System.Text;

namespace Section10Exercise.Entites
{
    abstract class Taxpayer
    {
        public string Nome { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer() { }

        public Taxpayer(string nome, double annualIncome)
        {
            Nome = nome;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxToPay();

    }
}
