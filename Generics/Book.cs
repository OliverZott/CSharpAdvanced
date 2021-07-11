namespace Generics
{
    public class Book
    {

        public string Title { get; set; }

        public string Isbn { get; set; }


        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string isbn) : this(title)
        {
            Isbn = isbn;
        }


    }
}
