using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC //Generic Collections
    {
        public void ListHandling()
        {
            List<string> numbers = new()
            {
                "1",
                "20",
                "30",
                "Deepk",
                "AAA"
            };
            numbers.Sort();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.Reverse();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            numbers.RemoveAt(1);
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(numbers.Contains("1"));
            numbers.Clear();
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

        }
        
        public void DictionaryHandling()
        {
            Dictionary<int,string> dt = new ()
            {
                { 1, "2" },
                { 3, "value" },
                { 4, "5" },
                {7,"9" }
            };
            dt.Remove(4);
            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Keys");

            foreach (var item in dt.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values");
            foreach (var item in dt.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: " + dt.Count);
        }
        
    }
}
