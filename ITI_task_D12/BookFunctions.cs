using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    public class BookFunctions
    {
        public static string GetTitle(Books book)
        {
            return book.Title;
        }

        public static string GetAuthors(Books book)
        {
            return string.Join(", ", book.Authors);
        }

        public static string GetISBN(Books book)
        {
            return book.ISBN;
        }

        public static string GetPrice(Books book)
        {
            return book.Price.ToString();
        }
    }
}
