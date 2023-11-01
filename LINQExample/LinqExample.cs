using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    internal class LinqExample
    {
        public static void SearchCourse(string str)
        {
            List<string> courses = new()
            {
                "C Tutorial",
                "Django",
                "Java Tutorial",
                "Mongo DB"
            };
            //var result = from c in courses                   //query syntax
            //             where c.Contains(str)
            //             select c;
            IEnumerable<string> result = courses.Where(c => c.Contains(str));  //method syntax  "c => c.Contains(str)" - predicate
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void SearchStudent(int id)
        {
            List<Student> students = new()
            {
                new Student(123,"Student1",22),
                new Student(456,"Student2",19),
                new Student(789,"Student3",24),
                new Student(987,"Student4",18),
                new Student(654,"Student5",21),
                new Student(432,"Student6",20),
            };
            Student? result = students.Find(s => s.StudentId == id);
            if (result != null)
            {
                Console.WriteLine("Student Id: " + result.StudentId + "  Name: " + result.Name +
                    "  Age: " + result.Age);
            }
            else
            {
                throw new Exception("Student not found");
            }
        }
        public static void SortByType()
        {
            ArrayList elements = new()
            {
                1,2,3,"Four",5,"Six"
            };
            var numbers = elements.OfType<int>();
            var strings = elements.OfType<string>();
            Console.Write("Numbers: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.Write("Strings: ");
            foreach (var element in strings)
            {
                Console.Write(element + " ");
            }
        }
        public static void SortStudent()
        {
            List<Student> students = new()
            {
                new Student(123,"Student5",22),
                new Student(456,"Student6",19),
                new Student(789,"Student1",24),
                new Student(987,"Student7",18),
                new Student(654,"Student5",21),












            var result=students.ToLookup(s => s.Name); //setting name as key
            //IEnumerable<Student> sortedstudents = students.OrderBy(s => s.Name).ThenBy(s => s.Age);
            foreach (var lookedupstudent in result)
            {
                Console.WriteLine("Student Name: " + lookedupstudent.Key);
                foreach(var s in lookedupstudent)
                {
                    Console.WriteLine("ID: "+s.StudentId);
                    Console.WriteLine("Age: " + s.Age);
                }
            }
        }
    }
}
