//18 - 10 - 2023
//using Assignments;
//using Assignments.Exceptions;

//int[] grades = new int[3];
//Console.WriteLine("Enter Name: ");
//string? name = Console.ReadLine();

//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine("Enter Grade" + i + ": ");
//    grades[i - 1] = Convert.ToInt32(Console.ReadLine());
//}
//Student student = new(name, grades);
//Console.WriteLine(name + "'s average: " + student.CalculateAverage());

//19 - 10 - 2023

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

//26 - 10 - 2023

//1

//Customer customer1 = new(123, "Customer 1", 987654321L, 220.66);
//Customer customer2 = new(456, "Customer 2", 678904567L, 638.47);
//Customer customer3 = new(789, "Customer 3", 537495989L, 837.37);

//Customer.customerlist.Add(customer1);
//Customer.customerlist.Add(customer2);
//Customer.customerlist.Add(customer3);

//Customer.SearchCustomer(987654321);
//Customer.SearchCustomer(123456789);
//Customer.DisplayAll();

//2

//CallRecord record1 = new(123, 987654321L, TimeOnly.MaxValue);
//CallRecord record2 = new(456, 123456789L, TimeOnly.MinValue);
//CallRecord record3 = new(789, 654738927L, TimeOnly.MinValue);
//CallRecord record4 = new(987, 654738927L, TimeOnly.MaxValue);


//CallRecord.calls.Add(record1);
//CallRecord.calls.Add(record2);
//CallRecord.calls.Add(record3);
//CallRecord.calls.Add(record4);

//CallRecord.CallHistory(654738927);

//CallRecord.TotalCalls();

//3

//Patient patient = new(123, "", 32, "Fever");
//try
//{
//    Patient.AddPatient(patient);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//27 - 10 - 2023

//1
//MedicalRecord mr1 = new(13, "", 23, "Fever", 34, 555);
//try
//{
//    MedicalRecord.AddMedicalRecord(mr1);
//}
//catch (InvalidPatientDataException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//MedicalRecord mr2 = new(14, "ABC", 34, "Headache", 56, -777);
//try
//{
//    MedicalRecord.AddMedicalRecord(mr2);
//}
//catch (InvalidMedicalRecordException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//MedicalRecord mr3 = new(14, "ABC", 34, "Headache", 56, 777);
//try
//{
//    MedicalRecord.AddMedicalRecord(mr3);
//}
//catch (InvalidMedicalRecordException ex)
//{
//    Console.WriteLine(ex.Message);
//}

////2

//string? flag = "Y";
//while (flag == "Y")
//{
//    Console.WriteLine("Select:   1.Add Patient    2.View Patients");
//    int choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)
//    {
//        case 1:
//            Console.Write("Enter patient ID: ");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter patient name: ");
//            string? name = Console.ReadLine();
//            Console.Write("Enter patient age: ");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Diagnosis: ");
//            string? diagnosis = Console.ReadLine();
//            Patient patient = new(id, name, age, diagnosis);
//            Patient.AddPatientRecord(patient);
//            break;
//        case 2:
//            Patient.ViewPatientData();
//            break;
//        default:
//            break;
//    }
//    Console.WriteLine("Press Y to continue, any other key to exit");
//    flag = Console.ReadLine();
//    if (flag != null)
//    {
//        flag = flag.ToUpper();
//    }
//}

//3

//string? flag = "Y";
//while (flag == "Y")
//{
//    Console.WriteLine("Select:   1.Add Medical History    2.View Medical History");
//    int choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)
//    {
//        case 1:
//            Console.Write("Enter Record ID: ");
//            int rid = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter Patient ID: ");
//            int pid = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter description: ");
//            string? desc = Console.ReadLine();
//            Console.Write("Date: ");
//            string? stringdate = Console.ReadLine();
//            DateOnly date = DateOnly.MinValue;
//            if (stringdate != null)
//            {
//                date = DateOnly.Parse(stringdate);
//            }
//            MedicalHistory medicalHistory = new(rid, pid, desc, date);
//            MedicalHistory.AddMedicalHistoryToList(medicalHistory);
//            MedicalHistory.AddMedicalHistory(medicalHistory);
//            break;
//        case 2:
//            Console.Write("Enter Patient ID: ");
//            int patientId = Convert.ToInt32(Console.ReadLine());
//            MedicalHistory.ViewMedicalHistory(patientId);
//            break;
//        default:
//            break;
//    }
//    Console.WriteLine("Press Y to continue, any other key to exit");
//    flag = Console.ReadLine();
//    if (flag != null)
//    {
//        flag = flag.ToUpper();
//    }
//}

//30 - 10 - 2023

//1

//var type1 = "Two";
//var type2 = 3;
//RoomReservation<string>.BookReservation(123, ref type1);//room type using string
//RoomReservation<int>.BookReservation(456, ref type2);//room type using int

//RoomReservation<string>.CancelReservation(123);

//2

//Product<ElectronicsProduct>.AddProduct(new ElectronicsProduct(123, "Apple", 23, 2, 5));
//Product<ClothingProduct>.AddProduct(new ClothingProduct(456, "Lee Cooper", 34, 2, "Medium"));

//Product<ElectronicsProduct>.UpdateProduct(123, "Mango", 45, 6);
//Product<ClothingProduct>.UpdateProduct(456, "Buffalo", 23, 7);

//Product<ElectronicsProduct>.RemoveProduct(123);
//Product<ClothingProduct>.SearchProduct(456);

//31 - 10 - 2023

//1

//public delegate int BonusCalculation(Employee employee, int performanceRating);//declare

//class Program
//{
//    public static void DelegateCall()
//    {
//        Console.Write("Enter employee id: ");
//        int id = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter first name: ");
//        string? firstName = Console.ReadLine();
//        Console.Write("Enter last name: ");
//        string? lastName = Console.ReadLine();
//        Console.Write("Enter age: ");
//        int age = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter performance rating: ");
//        int performanceRating = Convert.ToInt32(Console.ReadLine());
//        Employee employee = new(id, firstName, lastName, age);
//        BonusCalculation bonusdelegate = Employee.CalculateBonus; //binding target
//        Console.WriteLine("Bonus: " + bonusdelegate(employee, performanceRating));//Invoking delegate

//    }
//    public static void Main(string[] args)
//    {
//        DelegateCall();


//    }
//}

//2

//public delegate void EventNotification();//declare
//class Program
//{
//    public static void DelegateCall()
//    {


//        HotelEvent hotelEvent1 = new("Normal party", DateOnly.Parse("30-10-2023"), "TVM", 4);
//        HotelEvent hotelEvent2 = new("Luxury party", DateOnly.Parse("31-10-2023"), "Kochi", 10);

//        HotelEvent.Add(hotelEvent1);
//        HotelEvent.Add(hotelEvent2);

//        EventNotification eventNotification1 = HotelEvent.SendNotification; //binding target
//        EventNotification eventNotification2 = HotelEvent.SendStatus; //binding target
//        EventNotification eventNotificationMerged = eventNotification1 + eventNotification2;
//        eventNotificationMerged();//Invoking delegate
//    }
//    public static void Main(string[] args)
//    {
//        DelegateCall();
//    }
//}

//01 - 11 - 2023

//1

//TourismDestination destination1 = new("Burj", "Dubai", 2);
//TourismDestination.AddDestination(destination1);

//2

//TouristDestination.ViewDestinationsByRating(3);
//Console.WriteLine();
//TouristDestination.SortByPrice();
//Console.WriteLine();
//TouristDestination.Filter("India");

//02 - 11 - 2023

//1

//List<Hotel> hotels = new()
//{
//    new("Hotel1", 10,"Kerala","India",5),
//    new("Hotel2", 10,"TN","India",5),
//    new("Hotel3", 10,"Goa","India",5),
//    new("Hotel4", 10,"Agra","India",5),
//    new("Hotel5", 10,"Berlin","Germany",5),

//};
//foreach (Hotel hotel in hotels) {
//    Console.WriteLine("Available rooms at " + hotel.HotelName + ": " + hotel.AvailableRooms);
//        }
//await BookRoomsAsync(hotels[0], 2);
//await BookRoomsAsync(hotels[1], 3);
//await BookRoomsAsync(hotels[1], 8);
//await BookRoomsAsync(hotels[3], 1);
//await BookRoomsAsync(hotels[1], 3);

//foreach (Hotel hotel in hotels)
//{
//    Console.WriteLine("Available rooms at " + hotel.HotelName + ": " + hotel.AvailableRooms);
//}
//static async Task BookRoomsAsync(Hotel hotel, int numberofrooms)
//{
//    await hotel.BookRoomsAsync(numberofrooms);
//};*/

//2
//using Assignments;

//List<TourPackage> packages = new()
//{
//    new(123, "Kerala",DateOnly.Parse("02-10-2023"),5000),
//    new(456, "Tamil Nadu",DateOnly.Parse("22-10-2023"),7000),
//    new(789, "Karnataka",DateOnly.Parse("30-10-2023"),2000),
//    new(378, "Goa",DateOnly.Parse("02-11-2023"),1000),
//    new(287, "Delhi",DateOnly.Parse("12-12-2023"),2000),
//};


//TourPackage.AddTourPackage(packages[0]);
//TourPackage.AddTourPackage(packages[1]);
//TourPackage.AddTourPackage(packages[2]);
//TourPackage.AddTourPackage(packages[3]);

//TourPackage.BookPackage(123);
//TourPackage.BookPackage(456);
//TourPackage.BookPackage(378);

//Console.ReadLine();

//03-11-2023

//1
//using Assignments;
//CustomLinkedList linkedList = new();

//linkedList.AddNode(new(123,"Description1",true));
//linkedList.AddNode(new(456, "Description2", false));
//linkedList.AddNode(new(789, "Description3", true));

//linkedList.RemoveNode(123);
//linkedList.RemoveNode(333); // Trying to remove a non-existent node

//linkedList.DisplayList();

//2

using Assignments;


// Building the family tree
FamilyMember grandparent1 = new FamilyMember("Grandparent1", 70);
FamilyMember grandparent2 = new FamilyMember("Grandparent2", 72);
FamilyMember grandparent3 = new FamilyMember("Grandparent2", 72);

FamilyTree familyTree = new FamilyTree(grandparent1);

FamilyMember parent1 = new FamilyMember("Parent1", 40);
FamilyMember parent2 = new FamilyMember("Parent2", 38);
FamilyMember parent3 = new FamilyMember("Parent3", 32);

FamilyMember child1 = new FamilyMember("Child1", 15);
FamilyMember child2 = new FamilyMember("Child2", 12);
FamilyMember child3 = new FamilyMember("Child3", 14);


familyTree.AddFamilyMember(grandparent1, parent1);
familyTree.AddFamilyMember(grandparent1, parent2);
familyTree.AddFamilyMember(grandparent1, parent3);


familyTree.AddFamilyMember(parent1, child1);
familyTree.AddFamilyMember(parent2, child2);
familyTree.AddFamilyMember(parent3, child3);

// Displaying the family tree
familyTree.DisplayFamilyTree(familyTree.Root);