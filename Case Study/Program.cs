//See https://aka.ms/new-console-template for more information
using Case_Study;
using Case_Study.Exceptions;

//28-10-2023

//Console.WriteLine("Enter customer Id: ");
//var custid = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter customer name: ");
//var custname = Console.ReadLine();
//Console.WriteLine("Enter contact: ");

//var contact = Console.ReadLine();
//Console.WriteLine();

//var choice = "Y";
//var totalcost = 0;
//var totalbooks = 0;
//Book book1 = new()
//{
//    Title = "Marvel",
//    Author = "ABC",
//    ISBN = 234,
//    Price = 10,
//    Availability = true,
//    Type = "Non-Fiction"
//};
//Book book2 = new()
//{
//    Title = "DC",
//    Author = "XYZ",
//    ISBN = 345,
//    Price = 20,
//    Availability = true,
//    Type = "Fiction"
//};
//Book book3 = new()
//{
//    Title = "DCafg",
//    Author = "XYwZ",
//    ISBN = 3425,
//    Price = 220,
//    Availability = true,
//    Type = "Non-Fiction"
//};
//Book[] books = new Book[] { book1, book2, book3 };
//Booktype type = new()
//{
//    Books = books
//};


//while (choice == "Y")
//{
//    Console.WriteLine("Select:\n1 for Fiction\n2 for Non-fiction");
//    Console.Write("Your Selection: ");
//    var booktype = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine();

//    if (booktype == 1)
//    {
//        Console.WriteLine("Fiction books: ");

//        foreach (var b in books)
//        {

//            if (b.Type == "Fiction")
//            {

//                Console.WriteLine(b.Title + " by " + b.Author);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Non-fiction books: ");

//        foreach (var b in books)
//        {
//            if (b.Type == "Non-Fiction")
//            {

//                Console.WriteLine(b.Title + " by " + b.Author);
//            }
//        }
//    }
//    Console.WriteLine();

//    Console.WriteLine("Select:\n1.Search\n2.Order");
//    Console.Write("Your Selection: ");
//    var option = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine();

//    switch (option)
//    {
//        case 1:
//            Console.WriteLine("Enter title to search: ");
//            Console.Write("Your Selection: ");
//            var searchname = Console.ReadLine();
//            var searchedbook = type.SearchBook(searchname);
//            Console.WriteLine();
//            Console.WriteLine("Title: {0}\nAvailablility: {1}", searchedbook.Title, searchedbook.Availability);

//            break;
//        case 2:
//            Console.WriteLine("Enter book name to order: ");
//            Console.Write("Your Selection: ");
//            var bookname = Console.ReadLine();
//            Console.WriteLine();
//            var orderingbook = type.SearchBook(bookname);

//            Book[] book = new Book[] { orderingbook };
//            Order order = new(custid, custname, contact, book);
//            totalcost += order.CalculateTotalCost();
//            totalbooks += order.Books.Count();
//            Console.WriteLine("Total Cost: " + totalcost);
//            order.DisplayDetails();
//            Console.WriteLine("Total number of books: " + totalbooks);
//            break;
//        default: break;

//    }
//    Console.WriteLine();
//    Console.WriteLine("Enter Y to continue");
//    Console.Write("Your Selection: ");
//    choice = Console.ReadLine();
//    Console.WriteLine();

//}

//28-10-2023

OrderFulfillment orderFulfillment = new();
PhysicalProduct product1 = new(1, "Apple", 100, 2,7.3,"2*3*5");
PhysicalProduct product2 = new(2, "Motorola", 47, 3, 3.3, "2*4*5");
PhysicalProduct product3 = new(3, "Samsung", 80, 4, 4.23, "3*3*5");
DigitalProduct product4 = new(4, "Amazon", 300, 22, "amazon.com", ".jpg");
Customer customer = new(123, "NewCustomer", "customer@gmail.com");
List<Product> products = new()
{
    product1, product2, product3,product4
};
List<Customer> customers = new()
{
    customer
};
string? flag = "Y";
while (flag?.ToUpper() == "Y")
{
    Console.WriteLine("1.Admin        2.Customer");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("1.View Products        2.View Orders");
            int adminchoice = Convert.ToInt32(Console.ReadLine());
            switch (adminchoice)
            {
                case 1:
                    foreach (Product product in products)
                    {
                        Console.WriteLine("Product ID: {0}     Product Name: {1}     Price: {2}     In stock: {3}", product.ProductId, product.Name, product.Price, product.StockQuantity);
                    }
                    break;
                case 2:
                    if (OrderFulfillment.Orders != null)
                    {
                        foreach (Order order in OrderFulfillment.Orders)
                        {
                            Console.WriteLine("Order id: {0}     Product: {1}     Quantity: {2}     Customer: {3}", order.OrderId, order.Product.Name, order.Quantity, order.Customer.CustomerName);
                        }
                    }

                    break;
                default: break;

            }
            break;
        case 2:
            OrderFulfillment.Customers = customers;
            Console.WriteLine("1.Place order        2.View orders");
            int customerchoice = Convert.ToInt32(Console.ReadLine());
            switch (customerchoice)
            {
                case 1:
                    Console.WriteLine("1.Digital products     2.Physical products     3.Payment");
                    int productchoice = Convert.ToInt32(Console.ReadLine());
                    switch (productchoice)
                    {
                        case 1:
                            foreach (Product dproduct in products)
                            {
                                if (dproduct.GetType() == typeof(DigitalProduct))
                                {
                                    Console.WriteLine("Product ID: {0}     Product Name: {1}     Price: {2}     In stock: {3}", dproduct.ProductId, dproduct.Name, dproduct.Price, dproduct.StockQuantity);
                                }
                            }
                            Console.Write("Enter product id: ");
                            int productid = Convert.ToInt32(Console.ReadLine());
                            Product? orderedproduct = null;
                            foreach (Product dproduct in products)
                            {
                                if (dproduct.ProductId == productid)
                                {
                                    orderedproduct = dproduct;
                                }
                            }

                            

                            if (orderedproduct != null)
                            {
                                OrderFulfillment.Products?.Add(orderedproduct);
                                Console.Write("Enter quantity: ");
                                int quantity= Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                    orderFulfillment.PlaceOrder(customer, orderedproduct, quantity);
                                }
                                catch(OrderException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                               
                            }

                            break;

                        case 2:
                            foreach (Product pproduct in products)
                            {
                                if (pproduct.GetType() == typeof(PhysicalProduct))
                                {
                                    Console.WriteLine("Product ID: {0}     Product Name: {1}     Price: {2}     In stock: {3}", pproduct.ProductId, pproduct.Name, pproduct.Price, pproduct.StockQuantity);
                                }
                            }
                            Console.Write("Enter product id: ");
                            int pproductid = Convert.ToInt32(Console.ReadLine());
                            Product? porderedproduct = null;
                            foreach (Product pproduct in products)
                            {
                                if (pproduct.ProductId == pproductid)
                                {
                                    porderedproduct = pproduct;
                                }
                            }
                           

                            if (porderedproduct != null)
                            {
                                OrderFulfillment.Products?.Add(porderedproduct);
                                Console.Write("Enter quantity: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                try
                                {
                                   orderFulfillment.PlaceOrder(customer, porderedproduct, quantity);
                                }
                                catch (OrderException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Proceed to payment");
                            OrderFulfillment.ShowTotalCost(customer);
                            Console.Write("Enter amount to pay: ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                OrderFulfillment.ProcessPayment(customer, amount);
                            }
                            catch(OrderException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        default: break;
                    }
                    break;
                case 2:
                    if (OrderFulfillment.Orders != null)
                    {
                        foreach (Order order in OrderFulfillment.Orders)
                        {
                            if (order.Customer.CustomerName == customer.CustomerName)
                            {
                                Console.WriteLine("Order ID: {0}     Product Name: {1}     Paid: {2}", order.OrderId, order.Product.Name, order.IsPaid);
                            }
                        }
                    }
                    break;
                default: break;
            }
            break;
        default:
            break;
    }
    Console.WriteLine("Enter Y to continue");
    flag = Console.ReadLine();
}

