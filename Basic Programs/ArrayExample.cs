using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArrayExample
    {
        readonly int[] numbers=new int[5]; /*= { 10, 20, 39 }*/
        readonly int[,] nums = { { 1, 2, 3 }, { 5, 6, 7 } };/*new int[3,2];*/
        public void OneDim()
        {
            numbers[0] = 1;
            numbers[1] = 2;
            Console.WriteLine("1st");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //numbers=new int[5];
            numbers[0] = 16;
            numbers[1] = 02;
            Console.WriteLine("2nd");

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("3rd");
            Array.Clear(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public void TwoDim()
        {
            //nums[0,0] = 1;
            //nums[0,1] = 2;
            //nums[1,0] = 3;
            //nums[1,1] = 4;
            //nums[2,0] = 5;
            //nums[2,1] = 6;
           
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
        }
        public void JaggedArray()
        {
            int[][,] arr = new int[][,]
            {
                new int[,]{{1,2},{4,5}},
                new int[,]{{12,13,14},{17,18,19},{ 10, 11, 12 } },
                new int[,]{{23,24,25,26}},
            };
            for(int i = 0; i < arr.Length; i++)
            {
                int x=0;
                for(int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for(int k = 0; k < arr[j].Rank; k++)
                    {
                        Console.Write(arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    
    }
}
