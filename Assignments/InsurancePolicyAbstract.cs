using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal abstract class InsurancePolicyAbstract
    {
        public InsurancePolicyAbstract(int policyId, string? policyName, double premiumAmount)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            PremiumAmount = premiumAmount;
        }

        public int PolicyId { get; set; }
        public string? PolicyName { get; set; }
        public double PremiumAmount { get; set; }
        public abstract double CalculatePremium();
    }
}
