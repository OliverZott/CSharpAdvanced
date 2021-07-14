using System;

namespace Events
{
    public abstract class MessagingServices
    {
        public abstract void OnVideoEncoded(object source, VideoEventArgs args);
    }

    public class MailService : MessagingServices
    {
        public override void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Mail-Service: Sending mail ... {args.Video.Title}");
        }
    }

    public class MessageService : MessagingServices
    {
        public override void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Message-Service: Sending mail... {args.Video}");
        }
    }
}
