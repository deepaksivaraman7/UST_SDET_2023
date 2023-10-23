using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetailsNew : BankDetails //overriding happens here, because default constructor was provided
    {
        public BankDetailsNew(int custId, long accNo, string? name, string? status) : base(custId, accNo, name, status)
        {
        }
        public override void WelcomeMessage()   
        {
            Console.WriteLine("Welcome {0}", Name);
        }
        public new void ExitMessage()   //creating new instance for the ExitMessage(), new keyword for abstraction of base class
        {
            Console.WriteLine("Bye {0}", Name);
        }
    }
}
