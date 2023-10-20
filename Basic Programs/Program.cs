// See https://aka.ms/new-console-template for more information
using Basic_Programs;

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

////18-10-2023
//using Basic_Programs;

//int consumernumber=Convert.ToInt32(Console.ReadLine());
//Electricity electricity1 = new (consumernumber,5000,5500,"Old");
//Console.WriteLine(electricity1.consumername + "-" + electricity1.consumernumber + "-" + electricity1.CalculateBill());

//Electricity electricity2 = new(2345, 4400, 5200, "New");
//Console.WriteLine(electricity2.consumername + "-" + electricity1.consumernumber + "-" + electricity2.CalculateBill());

//19 - 10 - 2023
//using Basic_Programs;

//Employee employee = new(123, "Deepak", "IT", 10000);
//Console.WriteLine("Employee ID: {0}\nName: {1}\nDepartment: {2}\nBasic Pay: {3}\nSalary: {4}", employee.Eid, employee.Ename, employee.Dept, employee.Basicpay, employee.CalculateSalary());

//ArrayExample arrayExample = new ArrayExample();
//arrayExample.OneDim();
//arrayExample.TwoDim();
//arrayExample.JaggedArray();

//20-10-2023

//StudentMarks marks = new()/*new(1000, "AAA", "TRV", 98, 89, 95, 0, 0)*/;
//marks.RollNo = 1000;
//marks.StudentName = "Deepak";
//marks.City = "TVM";
//marks.Mark1 = 1;
//marks.Mark2 = 2;
//marks.Mark3 = 3;
//marks.DisplayStudentDetails();
//Console.WriteLine("Total marks: " + marks.CalculateTotal());
//Console.WriteLine("Average: " + marks.CalculateAverage());

//StudentGrade studentGrade = new()
//{
//    RollNo = 1000,
//    StudentName = "AAA",
//    City = "TRV",
//    Mark1 = 67,
//    Mark2 = 78,
//    Mark3 = 88
//};
//studentGrade.CalculateGrade();

//Console.WriteLine("1.TS  2.NTS");
//switch (Convert.ToInt32(Console.ReadLine()))
//{
//    case 1:
//        TeachingStaff ts = new();
//        Console.Write("StaffId: ");
//        ts.StaffId = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Name: ");
//        ts.StaffName = Console.ReadLine();
//        Console.Write("Specializations: ");
//        ts.Specializations = Console.ReadLine();
//        Console.Write("Semester: ");
//        ts.Sem = Convert.ToInt32(Console.ReadLine());
//        ts.DisplayStaffDetails();
//        break;
//    case 2:
//        NonTeachingStaff nts = new();
//        Console.Write("StaffId: ");
//        nts.StaffId = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Name: ");
//        nts.StaffName = Console.ReadLine();
//        Console.Write("Responsibilities: ");
//        nts.Responsibilities = Console.ReadLine();
//        Console.Write("Experience: ");
//        nts.Experience = Convert.ToInt32(Console.ReadLine());
//        nts.DisplayNTStaffDetails();
//        break;

//}

EV ev = new()
{
    VehNum = 123,
    Brand = "ABC",
    Model = "bv12",
    Type = "4 wheeler"
};
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());
PV pv = new()
{
    VehNum = 456,
    Brand = "XYZ",
    Model = "ab123",
    Type = "2 wheeler"
};
Console.WriteLine(pv.setTypeForVeh());
pv.Disp();
