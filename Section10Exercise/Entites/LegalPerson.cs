using System;
using System.Collections.Generic;
using System.Text;

namespace Section10Exercise.Entites
{
    class LegalPerson : Taxpayer
    {
        public int NumberOfEmployee { get; set; }

        public LegalPerson() { }
        public LegalPerson(string nome, double annualIncome, int numberOfEmployee) : base(nome, annualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double TaxToPay()
        {
            if (NumberOfEmployee > 10)
                return (AnnualIncome * 0.14);
            else
                return (AnnualIncome * 0.16);


        }
    }
}
