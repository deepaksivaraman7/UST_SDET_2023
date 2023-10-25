using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicyAbstract
    {
        public CarInsurance(int policyId, string? policyName, double premiumAmount, string? type) : base(policyId, policyName, premiumAmount)
        {
            Type = type;
        }
        public string? Type { get; set; }

        public override double CalculatePremium()
        {
            if (Type == "Petrol")
                return PremiumAmount + ((PremiumAmount * 2) / 100);
            else if (Type == "Diesel")
                return PremiumAmount + ((PremiumAmount * 3) / 100);
            else if (Type == "Electric")
                return PremiumAmount + ((PremiumAmount * 4) / 100);
            else
                return 0.0;

        }
    }
}
