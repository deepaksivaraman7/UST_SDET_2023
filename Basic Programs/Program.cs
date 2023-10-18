// See https://aka.ms/new-console-template for more information
//int num1, num2, ans;
//Console.WriteLine("Let us add two numbers");
//Console.WriteLine("Enter a number: ");
//num1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter another number: ");
//num2 = Convert.ToInt32(Console.ReadLine());
//ans = num1 + num2;
//Console.WriteLine("The sum is " + ans);

//Console.WriteLine("Let us concatenate two strings");
//string? s1, s2, s3;
//Console.WriteLine("Enter a string: ");
//s1 = Console.ReadLine();
//Console.WriteLine("Enter another string: ");
//s2 = Console.ReadLine();
//s3 = s1 + " " + s2;
//string[] s4=s3.Split(' ');
//Console.WriteLine("Here it is: " + s3);
//Console.WriteLine(s3.Substring(3));
//for (int i = 0; i < s4.Length; i++)
//{
//    Console.WriteLine(s4[i]);
//}

/*using Basic_Programs;

Calculation calculation = new Calculation();
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
double sum=calculation.Add(num1,num2);
Console.WriteLine(sum);*/
using Basic_Programs;

int consumernumber=Convert.ToInt32(Console.ReadLine());
Electricity electricity1 = new (consumernumber,5000,5500,"Old");
Console.WriteLine(electricity1.consumername + "-" + electricity1.consumernumber + "-" + electricity1.CalculateBill());

Electricity electricity2 = new(2345, 4400, 5200, "New");
Console.WriteLine(electricity2.consumername + "-" + electricity1.consumernumber + "-" + electricity2.CalculateBill());