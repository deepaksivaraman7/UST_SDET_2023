using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order:Customer
    {
        public Book[] Books { get; set; }
        public Order(int custId, string? custName, string? contactDetails, Book[] book) : base(custId, custName, contactDetails)
        {
            CustId = custId;
            CustName = custName;
            ContactDetails = contactDetails;
            Books = book;
        }

       
        public int CalculateTotalCost()
        {
            int cost = 0;
            if (Books != null)
            {
                foreach (var book in Books)
                {
                    cost += book.Price;
                }
            }
            return cost;
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine("Customer name: {0}\nNumber of books: {1}", CustName, Books.Count());
        }
        
    }
}
