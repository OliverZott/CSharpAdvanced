using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class BookRepository
    {

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title1", Price = 18.2M },
                new Book() { Title = "Title2", Price = 15.99M },
                new Book() { Title = "Title3", Price = 24.7M }

            };
        }
    }

    internal class Book
    {
        public string Title { get; set; }
        public decimal Price { get; init; }

    }
}
