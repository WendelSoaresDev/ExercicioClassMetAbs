using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassMetAbs.Entities
{
    class LegalPerson : TaxPayer
    {
        public int NumEmployee { get; set; }

        public LegalPerson(string name, double annualIncome, int numEmployee) : base(name, annualIncome)
        {
            NumEmployee = numEmployee;
        }

        public override double Tax()
        {
            
            if (NumEmployee < 10)
            {
                
                return  AnnualIncome * 0.16;

            }
            else
            {
                
                return  AnnualIncome * 0.14;
            }
        }
    }
}
