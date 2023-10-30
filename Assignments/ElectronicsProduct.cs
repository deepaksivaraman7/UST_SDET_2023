using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProduct : Product<ElectronicsProduct>
    {
        public ElectronicsProduct(int productId, string? name, double price, int quantity,int warrantyPeriod) : base(productId, name, price, quantity)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        

        public int WarrantyPeriod { get; set; }
        public void DisplayWarranty()
        {
            Console.WriteLine("Warranty Period: " + WarrantyPeriod);
        }
    }
}
