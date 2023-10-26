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
        public static List<Customer> customerlist = new();
        public static void SearchCustomer(long phonenumber)
        {
            Customer? customer = null;
            foreach (Customer? cust in customerlist)
            {
                if (cust.Phone == phonenumber)
                {
                    customer = cust;
                    break;
                }
            }
            if (customer != null)
            {
                Console.WriteLine("Customer ID: {0}\nCustomer Name: {1}\nBalance: {2}", customer.CustomerId, customer.Name, customer.AccountBalance);
            }
            else
            {
                Console.WriteLine("Customer not found");

            }
        }
        public static void DisplayAll()
        {
            foreach (Customer customer in customerlist)
            {
                Console.Write("ID: {0}    Name: {1}    Phone: {2}    Balance: {3}", customer.CustomerId, customer.Name, customer.Phone, customer.AccountBalance);
                Console.WriteLine();
            }
        }
    }
}
