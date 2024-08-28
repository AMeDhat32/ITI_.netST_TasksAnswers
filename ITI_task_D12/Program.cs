using static Day12.Delegate;
namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>
            {
                new Books("978-0-7356-6745-7", "C# 5.0 in a Nutshell", new string[] { "Joseph Albahari", "Ben Albahari" }, DateTime.Now, 29.99m),
                new Books("978-0-7356-8322-3", "LINQ Pocket Reference", new string[] { "Joseph Albahari", "Ben Albahari" }, DateTime.Now, 14.99m),

            };
            #region delegate
            BookFunctions bookFunctions = new BookFunctions();
            BookDelegate bookDelegate = BookFunctions.GetISBN;
            LibraryEngine.ProcessBooks(books.ToArray(), bookDelegate);
            LibraryEngine.ProcessBooks(books.ToArray(), BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books.ToArray(), BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books.ToArray(), BookFunctions.GetPrice);


            #endregion

        }
    }
}
