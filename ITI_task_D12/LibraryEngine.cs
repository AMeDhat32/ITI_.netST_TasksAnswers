using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    public class LibraryEngine
    {
        public static void ProcessBooks(Books[] books, Delegate.BookDelegate bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }
    }
}
