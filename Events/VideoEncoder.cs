using System;
using System.Threading;

namespace Events
{

    public class VideoEncoder
    {

        // 1. Define a delegate, if we don't use custom EventHandler<T>
        public delegate void VideoEncodedEventHandler(object sourceOfEvent, VideoEventArgs args);

        // 2. Define an event based on the delegate.
        // public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncoded2;



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);

            OnVideoEncoded(video);


            // heavily coupled because message-sending stuff
            // BETTER: use publisher and subscriber, which don't know anything about each other!
            /*
            _mailService.Send(new Mail());
            _messageService.Send(new Message());
            //*/
        }


        // 3. Raise the event.
        protected virtual void OnVideoEncoded(Video video)
        {
            // checking if there are any subscribers and call event
            VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});
        }
    }



    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }
}
