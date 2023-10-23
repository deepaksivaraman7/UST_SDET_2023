using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {

        public Employee(int employeeId,string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {
            EmployeeId=employeeId;
        }
        public int EmployeeId { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Full name: {0}\nAge: {1}", FirstName + " " + LastName, Age);
        }
    }
}
