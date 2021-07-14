using System;

namespace Events
{
    public abstract class MessagingServices
    {
        public abstract void OnVideoEncoded(object source, EventArgs args);
    }

    public class MailService : MessagingServices
    {
        public override void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail-Service: Sending mail!");
        }
    }

    public class MessageService : MessagingServices
    {
        public override void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Message-Service: Sending mail!");
        }
    }
}
