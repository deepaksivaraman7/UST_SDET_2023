using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        public string? name;
        public int[]? grades = new int[3];

        public Student(string? name, int[]? grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public double CalculateAverage()
        {
            if(grades == null)
            {
                return 0;
            }
            else
            {
                return grades.Average();
            }
        }
    }
    
}
