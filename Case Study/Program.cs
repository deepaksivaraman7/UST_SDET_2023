// See https://aka.ms/new-console-template for more information
using Case_Study;
Console.WriteLine("Enter customer Id: ");
var custid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter customer name: ");
var custname = Console.ReadLine();
Console.WriteLine("Enter contact: ");

var contact = Console.ReadLine();
Console.WriteLine();

var choice = "Y";
var totalcost = 0;
var totalbooks = 0;
Book book1 = new()
{
    Title = "Marvel",
    Author = "ABC",
    ISBN = 234,
    Price = 10,
    Availability = true,
    Type = "Non-Fiction"
};
Book book2 = new()
{
    Title = "DC",
    Author = "XYZ",
    ISBN = 345,
    Price = 20,
    Availability = true,
    Type = "Fiction"
};
Book book3 = new()
{
    Title = "DCafg",
    Author = "XYwZ",
    ISBN = 3425,
    Price = 220,
    Availability = true,
    Type = "Non-Fiction"
};
Book[] books = new Book[] { book1, book2, book3 };
Booktype type = new()
{
    Books = books
};


while (choice == "Y")
{
    Console.WriteLine("Select:\n1 for Fiction\n2 for Non-fiction");
    Console.Write("Your Selection: ");
    var booktype = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    if (booktype == 1) 
    {
            Console.WriteLine("Fiction books: ");

        foreach (var b in books)
        {

            if (b.Type == "Fiction")
            {

                Console.WriteLine(b.Title + " by " + b.Author);
            }
        }
    }
    else
    {
        Console.WriteLine("Non-fiction books: ");

        foreach (var b in books)
        {
            if (b.Type == "Non-Fiction")
            {

                Console.WriteLine(b.Title + " by " + b.Author);
            }
        }
    }
    Console.WriteLine();

    Console.WriteLine("Select:\n1.Search\n2.Order");
    Console.Write("Your Selection: ");
    var option = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (option)
    {
        case 1:
            Console.WriteLine("Enter title to search: ");
            Console.Write("Your Selection: ");
            var searchname = Console.ReadLine();
            var searchedbook = type.SearchBook(searchname);
            Console.WriteLine();
            Console.WriteLine("Title: {0}\nAvailablility: {1}", searchedbook.Title, searchedbook.Availability);

            break;
        case 2:
            Console.WriteLine("Enter book name to order: ");
            Console.Write("Your Selection: ");
            var bookname = Console.ReadLine();
            Console.WriteLine();
            var orderingbook = type.SearchBook(bookname);
            
            Book[] book = new Book[] { orderingbook };
            Order order = new(custid, custname, contact, book);
            totalcost += order.CalculateTotalCost();
            totalbooks += order.Books.Count();
            Console.WriteLine("Total Cost: " + totalcost);
            order.DisplayDetails();
            Console.WriteLine("Total number of books: " + totalbooks);
            break;
        default: break;

    }
    Console.WriteLine();
    Console.WriteLine("Enter Y to continue");
    Console.Write("Your Selection: ");
    choice = Console.ReadLine();
    Console.WriteLine();

}




