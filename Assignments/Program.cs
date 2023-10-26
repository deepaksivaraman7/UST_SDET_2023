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

//23 - 10 - 2023

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

//25 - 10 - 2023

//1

//InsurancePolicy policy = new(123, "New Policy", 200.5);
//Console.WriteLine("Before updating: " + policy.PremiumAmount);
//policy.RenewPolicy(300);
//Console.WriteLine("After updating: " + policy.PremiumAmount);
//policy.RenewPolicy();
//Console.WriteLine("After increasing 10%: " + policy.PremiumAmount);

//2

//LifeInsurance lifeInsurance = new(123, "Life Insurance", 2000.00, 23);
//CarInsurance petrolCar = new(1234, "Petrol Insurance", 1000.00, "Petrol");
//CarInsurance dieselCar = new(3456, "Diesel Insurance", 1000.00, "Diesel");
//CarInsurance electricCar = new(7890, "Electric Insurance", 1000.00, "Electric");
//Console.WriteLine("Petrol car: " + petrolCar.CalculatePremium());
//Console.WriteLine("Diesel car: " + dieselCar.CalculatePremium());
//Console.WriteLine("Electric car: " + electricCar.CalculatePremium());
//Console.WriteLine("Life Insurance: " + lifeInsurance.CalculatePremium());

//26-10-2023

//1

//Customer customer1 = new(123, "Customer 1", 987654321L, 220.66);
//Customer customer2 = new(456, "Customer 2", 678904567L, 638.47);
//Customer customer3 = new(789, "Customer 3", 537495989L, 837.37);

//List<Customer> customerlist = new()
//{
//    customer1,
//    customer2,
//    customer3
//};
//void SearchCustomer(long phonenumber)
//{
//    Customer? customer = null;
//    foreach (Customer? cust in customerlist)
//    {
//        if (cust.Phone == phonenumber)
//        {
//            customer = cust;
//            break;
//        }
//    }
//    if (customer != null)
//    {
//        Console.WriteLine("Customer ID: {0}\nCustomer Name: {1}\nBalance: {2}", customer.CustomerId, customer.Name, customer.AccountBalance);
//    }
//    else
//    {
//        Console.WriteLine("Customer not found");

//    }
//}
//void DisplayAll()
//{
//    foreach(Customer customer in customerlist)
//    {
//        Console.Write("ID: {0}    Name: {1}    Phone: {2}    Balance: {3}",customer.CustomerId, customer.Name,customer.Phone,customer.AccountBalance);
//        Console.WriteLine();
//    }
//}
//SearchCustomer(987654321);
//SearchCustomer(123456789);
//DisplayAll();

//2

CallRecord record1= new CallRecord(123,987654321L,TimeOnly.MaxValue);
CallRecord record2 = new CallRecord(456, 123456789L, TimeOnly.MinValue);
CallRecord record3 = new CallRecord(789, 654738927L, TimeOnly.MinValue);
CallRecord record4 = new CallRecord(987, 654738927L, TimeOnly.MaxValue);


List<CallRecord> calls = new()
{
    record1,
    record2,
    record3,
    record4
};
void CallHistory(long phone)
{
    foreach (var call in calls)
    {
        if (call.PhoneNumber == phone)
        {
            Console.WriteLine("Call ID: {0}   Call Time: {1}", call.CallId, call.CallTime);
        }
    }
}
CallHistory(654738927);
void TotalCalls()
{
    Dictionary<long, int> dict = new();
    int count = 1;
    foreach (var call in calls)
    {
        if (!dict.ContainsKey(call.PhoneNumber))
        {
            dict[call.PhoneNumber] = count;
        }
        else
        {
            dict[call.PhoneNumber] += 1;
        }
    }
    foreach (var number in dict) {
        Console.WriteLine("Phone Number: {0}   Number of calls: {1}",number.Key,number.Value);
    }
}
TotalCalls();

//3

Patient patient = new(123, "", 32, "Fever");
try
{
    patient.AddPatient(patient);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

