using System;

namespace ExceptionHandling
{
    class YouTubeException : Exception
    {

        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}