using System;

namespace Delegates
{
    public class PhotoProcessor
    {

        // instance of that delegate can hold pointer to function with same signature
        public delegate void PhotoFilterHandler(Photo photo);

        // with the delegate the Client is responsible for the filters)
        public void Process(string path, PhotoFilterHandler filterHandler)
        {

            var photo = Photo.Load(path);

            // remove hard-coded filters!
            /*
            var filter = new PhotoFilter();
            filter.ApplyBrightness(photo);
            filter.ApplyContrast(photo);
            filter.Resize(photo);
            //*/

            filterHandler(photo);

            photo.Save();
        }


        // Even easier with standard delegates
        public void AdvancedProcess(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }
}
