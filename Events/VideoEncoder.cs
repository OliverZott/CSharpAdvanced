using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {

        // 1. Define a delegate.
        public delegate void VideoEncodedEventHandler(object sourceOfEvent, EventArgs args);

        // 2. Define an event based on the delegate.
        public event VideoEncodedEventHandler VideoEncoded;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);

            OnVideoEncoded();


            // heavily coupled because message-sending stuff
            // BETTER: use publisher and subscriber, which don't know anything about each other!
            /*
            _mailService.Send(new Mail());
            _messageService.Send(new Message());
            //*/
        }


        // 3. Raise the event.
        protected virtual void OnVideoEncoded()
        {
            // checking if there are any subscribers and call event
            VideoEncoded?.Invoke(this, EventArgs.Empty);

            //Console.WriteLine("Video was successfully encoded.");
        }
    }
}
