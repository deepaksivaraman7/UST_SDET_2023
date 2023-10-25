using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance:InsurancePolicyAbstract
    {
        public LifeInsurance(int policyId, string? policyName, double premiumAmount, int age) : base(policyId, policyName, premiumAmount)
        {
            Age = age;
        }

        public int Age { get; set; }

        public override double CalculatePremium()
        {
            return PremiumAmount + ((PremiumAmount * Age) / 100);
        }
    }
}
