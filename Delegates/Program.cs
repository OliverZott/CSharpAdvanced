using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilter();

            // Example with custom delegate
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("test", filterHandler);

            // Example with Action
            photoProcessor.AdvancedProcess("teeest", photo => Console.WriteLine("Lambda expression."));
            //photoProcessor.AdvancedProcess("teeest", filterHandler));

        }


        // create custom filter function to be used with delegate
        public static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Removing red eyes.");
        }
    }
}
