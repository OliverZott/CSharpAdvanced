using System;

namespace Delegates
{
    public class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast.");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize image.");
        }
    }
}