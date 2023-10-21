using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Case_Study
{
    internal class Booktype
    {
        public string? Type { get; set; }
        public Book[]? Books { get; set; }
        public Book SearchBook(string? bookname)
        {
            Book searchedbook = new();
            if (Books != null)
            {
                foreach (var book in Books)
                {
                    if (book.Title == bookname && book.Availability==true)
                    {
                        searchedbook = book;
                    }

                }
            }
            return searchedbook;
        }
    }
}
