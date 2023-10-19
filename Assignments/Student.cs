using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        private string? studentName;
        private double[] marks=new double[3];
        private string? grade;

        public Student(string? studentName, double[] marks, string? grade)
        {
            this.studentName = studentName;
            this.marks = marks;
            this.grade = grade;
        }

        public string? StudentName { get => studentName; set => studentName = value; }
        public double[] Marks { get => marks; set => marks = value; }
        public string? Grade { get => grade; set => grade = value; }

        public double CalculateAverage()
        {
            double average=Marks.Average();
            return average;
        }
        public void GetMarksSummary()
        {
            Console.WriteLine(studentName+" has "+Marks.Length+" marks. "+"Highest Mark: "+Marks.Max()+", Lowest Mark: "+Marks.Min());
        }
    }
}
