namespace Events
{
    class Program
    {
        private static void Main()
        {

            var video = new Video() { Title = "Video Title 1" };
            var videoEncoder = new VideoEncoder();          // Publisher
            var mailService = new MailService();            // Subscriber
            var messageService = new MessageService();      // Subscriber

            // create subscription (rhs) according to event we are interested in (lhs)
            // LHS: Publisher and event
            // RHS: register handler for the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;        // NOT CALL to method - no brackets. Just a Pointer to method!
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;     // NOT CALL to method - no brackets. Just a Pointer to method!
            videoEncoder.Encode(video);

        }
    }
}
