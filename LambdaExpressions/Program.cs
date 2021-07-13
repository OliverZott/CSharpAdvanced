using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Square(5));


            // Use delegate to point to method
            Func<int, int> squareMethod = Square;
            // Use lambda inside delegate
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(7));



            var bookList = new BookRepository().GetBooks();
            // Book example with Predicate Method:
            List<Book> expensive = bookList.FindAll(IsExpensive);
            // Book example with Lambda Expression:
            List<string> cheap = bookList.Where(x => x.Price < 18).Select(x => x.Title).ToList();

            cheap.ForEach(System.Console.WriteLine);
            expensive.ForEach(b => System.Console.WriteLine(b.Title));

        }

        public static int Square(int value)
        {
            return value * value;
        }


        public static bool IsExpensive(Book book)
        {
            return book.Price > 20;
        }
    }
}
