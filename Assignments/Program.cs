//18-10-2023
using Assignments;

int[]grades = new int[3];
Console.WriteLine("Enter Name: ");
string? name = Console.ReadLine();

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Enter Grade"+i+": ");
    grades[i-1] = Convert.ToInt32(Console.ReadLine());
}
Student student = new(name, grades);
Console.WriteLine(name+"'s average: " + student.CalculateAverage());
