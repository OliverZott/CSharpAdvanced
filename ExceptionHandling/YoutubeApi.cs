using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class YoutubeApi
    {

        public List<Video> GetVideos(string user)
        {

            try
            {
                // Access youtube service
                // Read the data
                // Create list of video objects
                throw new Exception("Inner exception. Low level error.");
            }
            catch (Exception ex)
            {
                // Log
                throw new YouTubeException("Something went wrong with Video!", ex);
            }
            return new List<Video>()
            {
                new Video() {Name = "Video 1"},
                new Video() {Name = "Video 2"},
                new Video() {Name = "Video 3"}
                };
        }
    }
}
