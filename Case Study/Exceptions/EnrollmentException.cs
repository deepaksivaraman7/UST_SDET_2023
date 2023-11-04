using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.Exceptions
{
    internal class EnrollmentException:Exception
    {
        public EnrollmentException(string message) : base(message) { }
    }
}
