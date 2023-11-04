using Case_Study.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class EnrollmentRecord
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public static List<EnrollmentRecord> EnrollmentRecords = new List<EnrollmentRecord>();
        public static List<Course>Courses=new List<Course>();
        public EnrollmentRecord(Student student, Course course)
        {
            Student = student;
            Course = course;
            EnrollmentDate = DateTime.Now;
        }
        public static void DisplayCourses()
        {
            if (Courses != null)
            {
                foreach (var course in Courses)
                {
                    Console.WriteLine("Course code: {0}     Title: {1}     Instructor: {2}", course.CourseCode, course.Title, course.Instructor);
                }
            }
            else
            {
                throw new EnrollmentException("There are no courses to display");
            }
        }
        public static void DisplayRegisteredCourses(Student student)
        {
            var registeredrecords = EnrollmentRecords.Where(r => r.Student.StudentID == student.StudentID);
            if (registeredrecords != null)
            {
                foreach (var record in registeredrecords)
                {
                    Console.WriteLine("Course code: {0}     Title: {1}     Instructor: {2}     Enrolled date: {3}", record.Course.CourseCode, record.Course.Title, record.Course.Instructor, record.EnrollmentDate);
                }
            }
            else
            {
                throw new EnrollmentException("There areno registered courses to show");
            }
        }
        public static void AddCourse(Course course)
        {
            Courses.Add(course);
            Console.WriteLine("Course added");
        }
        public static void RemoveCourse(int coursecode)
        {
            Course course = Courses.FirstOrDefault(c => c.CourseCode == coursecode);
            if (course != null)
            {
                Courses.Remove(course);
                Console.WriteLine("Course removed");
            }
            else
            {
                throw new EnrollmentException("Course with course id not found");
            }
        }
        public static void Enroll(EnrollmentRecord record)
        {
            var searchrecord=EnrollmentRecords.FirstOrDefault(r=>r.Student.StudentID==record.Student.StudentID&&r.Course.CourseCode==record.Course.CourseCode);
            if (searchrecord == null)
            {
                EnrollmentRecords.Add(record);
                Console.WriteLine("Enrolled");
            }
            else
            {
                throw new EnrollmentException("Already enrolled in the course");
            }
        }
        public static void Withdraw(EnrollmentRecord record)
        {
            EnrollmentRecord withdrawrecord = EnrollmentRecords.FirstOrDefault(r => r.Student.StudentID == record.Student.StudentID && r.Course.CourseCode == record.Course.CourseCode);
            if (withdrawrecord != null)
            {
                EnrollmentRecords.Remove(withdrawrecord);
                Console.WriteLine("Withdrawn");
            }
            else
            {
                throw new EnrollmentException("Course not found for the student");
            }
        }
    }
}
