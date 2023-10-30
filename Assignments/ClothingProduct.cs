using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ClothingProduct : Product<ClothingProduct>
    {
        public ClothingProduct(int productId, string? name, double price, int quantity,string? size) : base(productId, name, price, quantity)
        {
            Size = size;
        }

        

        public string? Size { get; set; }
        public void DisplaySize()
        {
            Console.WriteLine("Size: " + Size);
        }
    }
}
