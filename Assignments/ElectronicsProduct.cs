using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProduct:Product
    {
        public ElectronicsProduct(string? productName, double price, int quantity, int warrantyPeriod) : base(productName, price, quantity)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public int WarrantyPeriod { get; set; }
        public void DisplayWarranty()
        {
            Console.WriteLine("Warranty Period: "+WarrantyPeriod);
        }
    }
}
