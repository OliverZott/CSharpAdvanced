namespace Delegates
{
    public class PhotoProcessor
    {

        public void Process(string path)
        {
            var photo = Photo.Load(path);

            var filter = new PhotoFilter();
            filter.ApplyBrightness(photo);
            filter.ApplyContrast(photo);
            filter.Resize(photo);

            photo.Save();
        }
    }
}
