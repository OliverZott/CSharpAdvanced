using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*
            var bookOne = new Book("Title1", "0000-0001");

            // possible because no constraint in GenericList class!
            var numbers = new GenericList<int>();
            numbers.Add(17);

            var books = new GenericList<Book>();
            books.Add(bookOne);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("Nr1", bookOne);
            //*/



            // Nullable example
            var number = new Nullable<int>(4);
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault);

            var number2 = new Nullable<int>();
            Console.WriteLine("Has value? " + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault);

            // Microsoft framework implementation
            // System.Nullable<> 


        }
    }
}
