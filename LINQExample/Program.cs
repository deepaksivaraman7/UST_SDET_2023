// See https://aka.ms/new-console-template for more information
using LINQExample;

LinqExample.SearchCourse("a");
try
{
    LinqExample.SearchStudent(123);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
LinqExample.SortByType();
Console.WriteLine();
LinqExample.SortStudent();