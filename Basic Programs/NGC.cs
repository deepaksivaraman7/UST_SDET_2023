using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NGC //Non-generic collections
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new()
            {
                "AA",
                20,
                30
            };
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Reverse();
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.RemoveAt(1);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(arrayList.Contains("AA"));
            arrayList.Clear();
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
           
        }
        public void StackHandling()
        {
            Stack st = new();
            st.Push(1);
            st.Push(2);
            st.Push("String");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine("Peek: "+ st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop: " + st.Pop());

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }

        public void QueueHandling()
        {
            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue("String");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek: " + queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void HashTableHandling()
        {
            Hashtable ht = new Hashtable
            {
                { 1, 2 },
                { "key", "value" },
                { 4, 5 },
                {7,9 }
            };
            ht.Remove("key");
            foreach(var item in ht)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Keys");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: "+ht.Count);
        }
        public void SortedListHandling()
        {
            SortedList sl = new()
            {
                { 3, 4 },
                { 0, 6 },
                { 1, 2 },
                { 4, "Value" }
            };
            foreach(var item in sl)
            {
                Console.WriteLine(item);
            }
        }
    }
}
