using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // without LINQ
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 16)
                {
                    cheapBooks.Add(book);
                }
            }



            // LINQ Query Operations
            var cheapBooks2 =
                from book in books
                where book.Price < 20
                orderby book.Price
                select book.Title;



            // LINQ Extension Methods
            var cheapBooks3 = books.Where(i => i.Price < 17).OrderBy(i => i.Price).ToList(); // .Select(b => b.Title
            cheapBooks3.ForEach(Console.WriteLine);
            cheapBooks3.ForEach(i => Console.WriteLine(i.Title + ": " + i.Price));
            Console.WriteLine("\n");



            // Example 1
            var specificBook = books.SingleOrDefault(b => b.Title == "book1");
            Console.WriteLine(specificBook == null);
            Console.WriteLine("\n");


            // Example 2
            var specificBook2 = books.Last(b => b.Title.Contains("ook"));
            Console.WriteLine(specificBook2.Title);
            Console.WriteLine("\n");


            // Example 3 - Pagination
            books.Skip(2).Take(2).Select(b => b.Title).ToList().ForEach(Console.WriteLine);


            // Example 4 - Aggregation
            Console.WriteLine("Max price: " + books.Max(b => b.Price));
            Console.WriteLine("\n");

        }
    }
}
