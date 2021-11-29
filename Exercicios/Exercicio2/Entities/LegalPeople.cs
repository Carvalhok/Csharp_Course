namespace Exercicio2.Entities
{
    class LegalPeople : People
    {
        public int EmployeeNumber { get; set; }

        public LegalPeople(string name, double annualIncome, int employeeNumber)
             : base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxPaid()
        {
            if (EmployeeNumber > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
                return AnnualIncome * 0.16;
        }
    }

}