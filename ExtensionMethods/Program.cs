using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost = "This is a way too long post ... blah blah blah ";
            var blogPost2 = "";
            var blogPost3 = string.Empty;

            Console.WriteLine(blogPost.Shorten2(5));
            Console.WriteLine(blogPost2.Shorten(3));
            Console.WriteLine(blogPost3.Shorten(3));



            // Example for implemented extension method
            IEnumerable<int> numbers = new int[] { 1, 2, 5, 84, 2, 4 };
            Console.WriteLine(numbers.Max());

        }
    }
}
