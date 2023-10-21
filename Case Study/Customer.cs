using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customer
    {
        private int custId;
        private string? custName;
        private string? contactDetails;

        public Customer(int custId, string? custName, string? contactDetails)
        {
            CustId = custId;
            CustName = custName;
            ContactDetails = contactDetails;
        }

        public int CustId { get => custId; set => custId = value; }
        public string? CustName { get => custName; set => custName = value; }
        public string? ContactDetails { get => contactDetails; set => contactDetails = value; }
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer ID: {0}\nCustomer Name: {1}\nCustomer Details: {2}", custId, custName, contactDetails);
        }

    }
}
