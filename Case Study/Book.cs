using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Book:Booktype
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
        public bool Availability {  get; set; }
        
        
    }
}
