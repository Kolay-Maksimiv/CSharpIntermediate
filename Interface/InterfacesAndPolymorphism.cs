namespace Interface
{
    public static class InterfacesAndPolymorphism
    {
        public class Mail
        {
        }

        //public class MailService
        //{
        //    public void Send(Mail mail)
        //    {
        //        Console.WriteLine("Sending email ...");
        //    }
        //}

        public class Video
        {
        }

        public interface INotificationChannel
        {
            void Send(Message message);
        }

        public class MailNotificationChannel : INotificationChannel
        {
            public void Send(Message message)
            {
                Console.WriteLine("Sending email ...");
            }
        }

        public class SmsNotificationChannel : INotificationChannel
        {
            public void Send(Message message)
            {
                Console.WriteLine("Sending SMS ...");
            }
        }

        public class Message
        {
        }

        public class VideoEncoder
        {
            private readonly IList<INotificationChannel> _notificationChannels;
            public VideoEncoder()
            {
                _notificationChannels = new List<INotificationChannel>();
            }
            public void Encode(Video video)
            {
                //Video encoding logic
                //...

                foreach (var channel in _notificationChannels)
                    channel.Send(new Message());
            }

            public void RegisterNotificationChannel(INotificationChannel channel)
            {
                _notificationChannels.Add(channel);
            }
        }

        public static void InterfacesAndPolymorphismProgram()
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}