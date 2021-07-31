using System;
using System.Runtime.InteropServices.ComTypes;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime date = null;  // value type cannot be nullable

            Nullable<DateTime> date0 = null;

            DateTime? date = null;
            Console.WriteLine(date ?? DateTime.UtcNow);
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("\n");

            // Null-Coalescing operator '??'
            DateTime date2 = date ?? DateTime.Today;
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Now;  // same with ternary operator
            Console.WriteLine(date2);
        }
    }
}
