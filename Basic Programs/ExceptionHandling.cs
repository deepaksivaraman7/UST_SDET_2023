using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {

            int[] num = { 10, 20, 30 };
            //int res = Num1 / Num2;
            //Console.WriteLine(res);
            for (int i = 0; i <= 3; i++)
            {
                int res = num[i] / Num2;
                Console.WriteLine(res);
            }


        }
        public void NumCheck1()
        {
            if (Num1 >= 100)
            {
                Console.WriteLine("Success");
            }
            else
            {
                //throw new ArgumentException(MyExceptions.dmessagelist["Less than 100"]);
                throw new Number1Exception(MyExceptions.dmessagelist["Less than 100"]);
            }
            
        }
        public void NumCheck2()
        {
            if (Num2 < 100)
            {
                Console.WriteLine("Success");
            }
            else
            {
                //throw new ArgumentException(MyExceptions.dmessagelist["More than 100"]);
                throw new Number2Exception(MyExceptions.dmessagelist["More than 100"]);
            }
        }
    }
}
