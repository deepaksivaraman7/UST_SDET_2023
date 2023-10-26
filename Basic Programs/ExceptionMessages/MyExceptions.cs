using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        public static List<string> exmessagelist = new()
        {
            "Dont give 0 for denominator",
            "Index is out of range",
            "Unknown exception occured"
        };
        public static Dictionary<string, string> dmessagelist = new()
        {
            { "Denominator","Dont give 0 for denominator" },
            { "Range","Index is out of range" },
            { "Unknown","Unknown exception occured" },
            {"Less than 100","Number is less than 100" },
            {"More than 100","Number is more than 100" }
        };
    }
    internal class Number1Exception : Exception
    {
        public Number1Exception(string message) : base(message)
        {

        }
    }
    internal class Number2Exception : Exception
    {
        public Number2Exception(string message) : base(message)
        {

        }
    }
}
