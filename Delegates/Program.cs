using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo();
            var photoProcessor = new PhotoProcessor();

            photoProcessor.Process("test");
        }
    }
}
