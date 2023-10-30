// See https://aka.ms/new-console-template for more information
using Basic_Programs;
//using Basic_Programs.ExceptionMessages;

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
//ts.StaffName = Console.ReadLine();
//Console.Write("Specializations: ");
//ts.Specializations = Console.ReadLine();
//Console.Write("Semester: ");
//ts.Sem = Convert.ToInt32(Console.ReadLine());
//ts.DisplayStaffDetails();
//break;
//    case 2:
//    NonTeachingStaff nts = new();
//    Console.Write("StaffId: ");
//    nts.StaffId = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Name: ");
//    nts.StaffName = Console.ReadLine();
//    Console.Write("Responsibilities: ");
//    nts.Responsibilities = Console.ReadLine();
//    Console.Write("Experience: ");
//    nts.Experience = Convert.ToInt32(Console.ReadLine());
//    nts.DisplayNTStaffDetails();
//    break;

//}

//EV ev = new()
//{
//    VehNum = 123,
//    Brand = "ABC",
//    Model = "bv12",
//    Type = "4 wheeler"
//};
//ev.Disp();
//Console.WriteLine(ev.setTypeForVeh());
//PV pv = new()
//{
//    VehNum = 456,
//    Brand = "XYZ",
//    Model = "ab123",
//    Type = "2 wheeler"
//};
//Console.WriteLine(pv.setTypeForVeh());
//pv.Disp();

//21 - 10 - 2023

//Doctor doctor = new();
//doctor.AddNewDoctor(1234, "ABC");
//doctor.DisplayDoctorDetails();
//doctor.ModifyDoctor(6789, "XYZ");
//doctor.DisplayDoctorDetails();

//doctor.BookApp(123, "new");
//doctor.DelApp("new");


//23 - 10 - 2023
//Polymorphism - overloading
//BankDetails details = new(123, 987654321L, "Deepak", "Active");
//BankDetails details1 = new();
//BankDetails details2 = new(456, 123456789L, "New");
//BankDetailsNew newdetails = new(321, 567889997L, "BankDetailsNew", "Active");
//details.WelcomeMessage();
//newdetails.WelcomeMessage();//overriding
//Console.WriteLine("1.Customer ID  2.Account No  3.Name");
//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Customer ID: ");
//        details.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        details1.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        newdetails.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));

//        break;
//    case 2:
//        Console.WriteLine("Account No: ");
//        details.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
//        details1.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
//        details2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));

//        break;
//    case 3:
//        Console.WriteLine("Name: ");
//        details.GetAccountDetails(Console.ReadLine());
//        details1.GetAccountDetails(Console.ReadLine());
//        details2.GetAccountDetails(Console.ReadLine());

//        break;
//    default:
//        Console.WriteLine("Enter between 1-3");
//        break;
//}

//BankDetails.ExitMessage(); //static method
//newdetails.ExitMessage();

//25-10-2023

//NGC nGC = new();
//nGC.ArrayListHandling();
//nGC.StackHandling();
//Console.WriteLine("Queue");
//nGC.QueueHandling();
//Console.WriteLine("HashTable");
//nGC.HashTableHandling();
//Console.WriteLine("SortedList");
//nGC.SortedListHandling();

//Basic_Programs.GC gC = new();
//gC.ListHandling();
//gC.DictionaryHandling();

//26-10-2023

//ExceptionHandling handling = new(20, 104);
//try
//{
//    handling.Divide();
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine(MyExceptions.dmessagelist["Denominator"]);
//    Console.WriteLine(MyExceptions.exmessagelist[0]);
//    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyExceptions.dmessagelist["Range"]);
//    Console.WriteLine(MyExceptions.exmessagelist[1]);
//    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyExceptions.dmessagelist["Unknown"]);
//    Console.WriteLine(MyExceptions.exmessagelist[2]);
//    Console.WriteLine(ex.Message + " In " + ex.Source + ex.StackTrace);
//}
//finally
//{
//    Console.WriteLine("Done");
//}
//try
//{
//    handling.NumCheck1();
//}
//catch (Number1Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    handling.NumCheck2();
//}
//catch (Number2Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//27-10-2023

//FileOperations.CreateFile();
//FileOperations.WriteData();
//FileOperations.ReadData();
//FileOperations.CopyMoveFile();
//FileOperations.DeleteFile();
//FileOperations.FileProperties();

//30-10-2023

//GenericsExample<int> g1 = new(10, 20);
//Console.WriteLine(g1.Val1+" "+g1.Val2);
//GenericsExample<string> g2 = new("string1", "string2");
//Console.WriteLine(g2.Val1 + " " + g2.Val2);
//GenericsExample<double> g3 = new(10.02, 20.67);
//Console.WriteLine(g3.Val1 + " " + g3.Val2);

//GenericsExample<int>ga=new(new int[3]{10,20,30});
//ga.Display();

//int n1 = 10, n2 = 20;
//char c1 = 'A', c2 = 'B';

//GenericsExample<int>.Swap(ref n1, ref n2);
//Console.WriteLine(n1 + " " + n2);
//GenericsExample<char>.Swap(ref c1, ref c2);
//Console.WriteLine(c1 + " " + c2);
