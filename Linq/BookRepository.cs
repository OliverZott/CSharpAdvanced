using System.Collections.Generic;

namespace Linq
{
    class BookRepository
    {

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book 1", Price = 20},
                new Book() {Title = "Book 1", Price = 15.20f},
                new Book() {Title = "Book 2", Price = 14.99f},
                new Book() {Title = "Book 3", Price = 12.50f},
                new Book() {Title = "Book 4", Price = 19.99F},
                new Book() {Title = "Book 5", Price = 23.70F}
            };
        }
    }
}
