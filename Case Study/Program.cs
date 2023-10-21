// See https://aka.ms/new-console-template for more information
using Case_Study;
Console.WriteLine("Enter customer id: ");
var custid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter customer name: ");

var custname = Console.ReadLine();
Console.WriteLine("Enter description: ");

var desc = Console.ReadLine();
var choice = "Y";
var totalcost = 0;
var totalbooks = 0;

while (choice == "Y")
{
    Console.WriteLine("1 for Fiction 2 for Non-fiction");
    var booktype = Convert.ToInt32(Console.ReadLine());
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
    Booktype allbooks = new()
    {

        Books = books
    };

    if (booktype == 1)
    {
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
        foreach (var b in books)
        {
            if (b.Type == "Non-Fiction")
            {
                Console.WriteLine(b.Title + " by " + b.Author);
            }
        }
    }
    Console.WriteLine("1.Search\n2.Order");
    var option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter title to search: ");
            var searchname = Console.ReadLine();
            var searchedbook = allbooks.SearchBook(searchname);
            Console.WriteLine("Title: {0}\nAvailablility: {1}", searchedbook.Title, searchedbook.Availability);

            break;
        case 2:
            Console.WriteLine("Enter book name to order: ");
            var bookname = Console.ReadLine();
            var orderingbook = allbooks.SearchBook(bookname);
            
            Book[] book = new Book[] { orderingbook };
            Order order = new(custid, custname, desc, book);
            totalcost += order.CalculateTotalCost();
            totalbooks += order.Books.Count();
            Console.WriteLine("Total Cost: " + totalcost);
            order.DisplayDetails();
            Console.WriteLine("Total number of books: " + totalbooks);
            break;
        default: break;

    }
    Console.WriteLine("Enter Y to continue");
    choice = Console.ReadLine();
}




