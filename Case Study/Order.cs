using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order
    {
        public Order(int orderId, Customer customer, Product product, int quantity, double totalAmount, bool isPaid, bool isDelivered)
        {
            OrderId = orderId;
            Customer = customer;
            Product = product;
            Quantity = quantity;
            TotalAmount = totalAmount;
            IsPaid = isPaid;
            IsDelivered = isDelivered;
        }

        //public Book[] Books { get; set; }
        //public Order(int customerId, string? customerName, string? contactDetails, Book[] book) : base(customerId, customerName, contactDetails)
        //{
        //    CustomerId = customerId;
        //    CustomerName = customerName;
        //    ContactDetails = contactDetails;
        //    Books = book;
        //}


        //public int CalculateTotalCost()
        //{
        //    int cost = 0;
        //    if (Books != null)
        //    {
        //        foreach (var book in Books)
        //        {
        //            cost += book.Price;
        //        }
        //    }
        //    return cost;
        //}

        //public void DisplayDetails()
        //{
        //    Console.WriteLine("Customer ID: {2}\nQuantity: {1}\nCustomer name: {0}", CustName, Books.Count(),CustId);

        //}
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDelivered { get; set; }
    }
}
