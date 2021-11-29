namespace Exercicio2.Entities
{
    class PhysicalPeople : People
    {
        public double HealthExpenditure { get; set; }

        public PhysicalPeople(string name, double annualIncome, double healthExpenditure)
           : base(name, annualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double TaxPaid()
        {
            if (AnnualIncome < 20000.00)
            {
                if (HealthExpenditure != 0.0)
                {
                    return AnnualIncome * 0.15 - HealthExpenditure * 0.5;
                }
                else return AnnualIncome * 0.15;
            }
            else
            {
                if (HealthExpenditure != 0.0)
                {
                    return AnnualIncome * 0.25 - HealthExpenditure * 0.5;
                }
                else return AnnualIncome * 0.25;
            }

        }
    }
}


