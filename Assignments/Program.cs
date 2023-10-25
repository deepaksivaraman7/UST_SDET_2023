//18-10-2023
using Assignments;

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

//1
//Product product1 = new("Mango", 20, 5);
//Product product2 = new("Apple", 30, 6);
//Product product3 = new("Orange", 40, 7);
//Product[] products = { product1, product2, product3 };
//product1.SetPrice(5);
//foreach (Product product in products)
//{
//    Console.WriteLine("Product name-" + product.ProductName);
//    Console.WriteLine("Price-" + product.Price);
//    Console.WriteLine("Quantity-" + product.Quantity);
//    Console.WriteLine("Product value-" + product.ProductValue());
//}

//2
//double[] marks1 = { 90, 80, 70 };
//double[] marks2 = { 10, 20, 30 };
//double[] marks3 = { 40, 50, 60 };

//Student student1 = new("Deepak", marks1, "A");
//Student student2 = new("ABC", marks2, "F");
//Student student3 = new("XYZ", marks3, "D");

//Student[] students = { student1, student2, student3 };
//foreach (Student student in students)
//{
//    Console.WriteLine("Student name-" + student.StudentName);
//    Console.Write("Marks-");
//    foreach (double mark in student.Marks)
//    {
//        Console.Write(mark + " ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("Total-" + student.Marks.Sum());
//    Console.WriteLine("Average-" + student.Marks.Average());
//    Console.WriteLine("Grade-" + student.Grade);

//    student.GetMarksSummary();
//}

//20 - 10 - 2023

//1
//ElectronicsProduct ep = new("Samsung", 22, 12, 2);
//ep.DisplayWarranty();

//2
//DigitalProduct dp = new("Sony", 200, 2, 4, "MP3");
//dp.DisplayFormat();

//3
//ClothingProduct cp = new("Lee Cooper", 100, 22, "Medium");
//cp.DisplaySize();
//cp.DisplayProducts();
//dp.DisplayProducts();
//ep.DisplayProducts();

//23-10-2023

//1
//Employee employee = new(123, "Deepak", "Sivaraman", 123);
//employee.DisplayInfo();

//2
//Circle circle = new()
//{
//    Radius = 10,
//};
//Rectangle rectangle = new()
//{
//    Length = 20,
//    Width = 15
//};
//circle.Draw();
//rectangle.Draw();

//25-10-2023

//1

InsurancePolicy policy = new(123, "New Policy", 200.5);
Console.WriteLine("Before updating: "+policy.PremiumAmount);
policy.RenewPolicy(300);
Console.WriteLine("After updating: "+policy.PremiumAmount);
policy.RenewPolicy();
Console.WriteLine("After increasing 10%: "+policy.PremiumAmount);

//2

LifeInsurance lifeInsurance = new(123, "Life Insurance", 2000.00, 23);
CarInsurance petrolCar = new(1234, "Petrol Insurance", 1000.00, "Petrol");
CarInsurance dieselCar = new(3456, "Diesel Insurance", 1000.00, "Diesel");
CarInsurance electricCar = new(7890, "Electric Insurance", 1000.00, "Electric");
Console.WriteLine("Petrol car: "+petrolCar.CalculatePremium());
Console.WriteLine("Diesel car: " + dieselCar.CalculatePremium());
Console.WriteLine("Electric car: " + electricCar.CalculatePremium());
Console.WriteLine("Life Insurance: " + lifeInsurance.CalculatePremium());


