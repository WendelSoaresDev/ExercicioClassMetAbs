
namespace ExercicioClassMetAbs.Entities
{
    class PhysicalPerson : TaxPayer
    {
        public double HealthEx { get; set; }

        public PhysicalPerson(string name, double annualIncome, double healthEx) : base(name, annualIncome)
        {
            HealthEx = healthEx;
        }

        public override double Tax()
        {
            double tax = 0;

            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
                tax -= HealthEx / 2;
                return tax;

            }
            else 
            {
               tax = AnnualIncome * 0.25;
               tax -= HealthEx / 2;
               return tax;
            }
            


        }
    }
}
