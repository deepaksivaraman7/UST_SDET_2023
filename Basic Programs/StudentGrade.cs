using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentGrade:StudentMarks
    {
        public string? Grade { get; set; }
        
        public void CalculateGrade()
        {
            Total = CalculateTotal();
            Average = CalculateAverage();
            double gradecheck=Average%10;
            switch (gradecheck) { 
                    case 5:
                    Console.WriteLine("D");
                    break;
                    case 6: Console.WriteLine("C");
                    break;
                    case 7: Console.WriteLine("B");
                    break;
                    case 8: Console.WriteLine("A");
                    break;
                    case 9: Console.WriteLine("A+");
                    break;
                    case 10: Console.WriteLine("OS");
                    break;
                    default:
                    Console.WriteLine("F");
                    break;

            }
            
        }
    }
}
