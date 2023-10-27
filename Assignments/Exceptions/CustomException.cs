using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Exceptions
{
    internal class CustomException
    {
        public static Dictionary<string, string> dmessagelist = new()
        {
            { "Denominator","Dont give 0 for denominator" },
            { "Range","Index is out of range" },
            { "Unknown","Unknown exception occured" },
            {"Less than 100","Number is less than 100" },
            {"More than 100","Number is more than 100" },
            {"String null","Name and diagnosis should not be empty" },
            {"Negative number","Number provided is negative" }
        };
    }
    internal class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string message) : base(message)
        {

        }
    }
    internal class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string message) : base(message)
        {

        }
    }
}
