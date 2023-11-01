using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    internal class Student
    {
        public Student(int studentId, string? name, int age)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
        }

        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
