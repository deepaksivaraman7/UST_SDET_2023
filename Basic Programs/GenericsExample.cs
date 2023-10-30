using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericsExample<T> where T : Exception 
    {
        //private T val1,val2;
        //private T[] arr;
        //public GenericsExample(T[] arr)
        //{
        //    Arr = arr;
        //}
        //public static void Swap(ref T num1, ref T num2)
        //{
        //    T temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //}

        //public T Val1 { get => val1; set => val1 = value; }
        //public T Val2 { get => val2; set => val2 = value; }
        //public T[] Arr { get => arr; set => arr = value; }
        //public void Display()
        //{
        //    foreach (var item in Arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
