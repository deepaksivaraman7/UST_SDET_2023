using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public Customer(int customerId, string? name, long phone, double accountBalance)
        {
            CustomerId = customerId;
            Name = name;
            Phone = phone;
            AccountBalance = accountBalance;
        }

        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public long Phone { get; set; }
        public double AccountBalance { get; set; }
    }
}
