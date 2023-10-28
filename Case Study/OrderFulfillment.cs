using Case_Study.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class OrderFulfillment
    {
        public List<Product>? Products { get; set; }
        public List<Customer>? Customers { get; set; }
        public List<Order>? Orders { get; set; }
        public void PlaceOrder(Customer customer, Product product, int quantity)
        {
            if (product.StockQuantity < quantity)
            {
                throw new OrderException("Product out of stock");
            }
            double totalamount = product.Price * quantity;
            var orderid = 1;
            if (Orders != null)
            {
                orderid += 1;
            }
            Order order = new(orderid, customer, product, quantity, totalamount, false, false);
            Orders?.Add(order);
            customer.PlacedOrders?.Add(order);
            Console.WriteLine("Order placed");
        }
        public static void ProcessPayment(Customer customer, double amount)
        {
            double totalcost = 0.0;
            if (customer.PlacedOrders != null)
            {
                foreach (var order in customer.PlacedOrders)
                {
                    totalcost += order.TotalAmount;
                }

                if (amount > 0 && amount <= totalcost)
                {
                    foreach (var order in customer.PlacedOrders)
                    {
                        order.IsPaid = true;
                    }
                }
                else
                {
                    throw new OrderException("Payment Error. Insufficient balance.");
                }
            }
        }
        public void DeliverProduct(Customer customer, Product product)
        {
            Order? order = null;
            foreach (var o in Orders)
            {
                if (o.Customer == customer && o.Product == product)
                {
                    order = o;
                    break;
                }
            }
            if (order != null && order.IsPaid)
            {
                order.IsDelivered = true;

                if (product is PhysicalProduct physicalProduct)
                {
                    double shippingcosts = physicalProduct.Weight * 0.1;
                    Console.WriteLine("Product delivered. Shipping cost: {0}", shippingcosts);
                }
                else if (product is DigitalProduct digitalProduct)
                {
                    Console.WriteLine("Digital product delivered. Download link: {0}",digitalProduct.DownloadLink);
                }
            }
            else
            {
                throw new OrderException("Error, Order not found or not paid");
            }
        }
    }
}
