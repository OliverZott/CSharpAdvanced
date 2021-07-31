using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            object obj = "Olli";


            // Call method
            Console.WriteLine("GetHashCode: " + obj.GetHashCode());
            Console.WriteLine("GetType: " + obj.GetType());


            // Use reflection to call method
            //var methodInfo = obj.GetType().GetMethod("GetHashCode") ?? null;
            //methodInfo?.Invoke(null, null);


            // Use dynamic instead:
            // Object should have Optimize-method at runtime!
            object excelObject = "excel object";
            // excelObject.Optimize();  // compile-time error
            dynamic excelObject2 = "excel object2";
            // excelObject2.Optimize();  // throws runtime error



            // Example 2 (use debugger)
            dynamic name = "Olli";
            // name++; // runtime error
            name = 14;
            name++;
            Console.WriteLine(name);


        }
    }
}
