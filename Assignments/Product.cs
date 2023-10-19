using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        private string? productName;
        private double price;
        private int quantity;

        public Product(string? productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void SetPrice(double newPrice)
        {
            Price= newPrice;
        }
        public double ProductValue()
        {
            double totalvalue = Price*Quantity;
            return totalvalue;

        }
    }
   
}
