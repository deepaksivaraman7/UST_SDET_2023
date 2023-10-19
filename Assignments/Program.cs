//18-10-2023
//using Assignments;

//int[]grades = new int[3];
//Console.WriteLine("Enter Name: ");
//string? name = Console.ReadLine();

//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine("Enter Grade"+i+": ");
//    grades[i-1] = Convert.ToInt32(Console.ReadLine());
//}
//Student student = new(name, grades);
//Console.WriteLine(name+"'s average: " + student.CalculateAverage());

//19-10-2023
using Assignments;

Product product1 = new("Mango", 20, 5);
Product product2 = new("Apple", 30, 6);
Product product3 = new("Orange", 40, 7);
Product[] products = {product1, product2, product3};
product1.SetPrice(5);
foreach (Product product in products)
{
    Console.WriteLine("Product name-"+product.ProductName);
    Console.WriteLine("Price-"+product.Price);
    Console.WriteLine("Quantity-"+product.Quantity);
    Console.WriteLine("Product value-" + product.ProductValue());
}
double[] marks1 = { 90, 80, 70 };
double[] marks2 = { 10, 20, 30 };
double[] marks3 = { 40, 50, 60 };

Student student1 = new("Deepak", marks1, "A");
Student student2 = new("ABC", marks2, "F");
Student student3 = new("XYZ", marks3, "D");

Student[] students = {student1,student2,student3};
foreach (Student student in students)
{
    Console.WriteLine("Student name-" + student.StudentName);
    Console.Write("Marks-");
    foreach (double mark in student.Marks)
    {
        Console.Write(mark+" ");
    }
    Console.WriteLine();
    Console.WriteLine("Total-" + student.Marks.Sum());
    Console.WriteLine("Average-" + student.Marks.Average());
    Console.WriteLine("Grade-" + student.Grade);

    foreach(Student stud in students)
    {
        stud.GetMarksSummary();

    }
}