namespace Section10Exercise.Entites
{
    class PhysicalPerson : Taxpayer
    {
        public double HealthExpenditure { get; set; }

        public PhysicalPerson(string nome, double annualIncome, double healthExpenditure) : base(nome, annualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double TaxToPay()
        {
            if(AnnualIncome <= 20000.00)
            {
                if(HealthExpenditure == 0)
                    return (AnnualIncome * 0.15) - (HealthExpenditure * 0.50);

                else
                    return (AnnualIncome * 0.15);
            }
            else
            {
                if (HealthExpenditure == 0)
                    return (AnnualIncome * 0.25) - (HealthExpenditure * 0.50);

                else
                    return (AnnualIncome * 0.25);
            }
            
        }
    }
}
