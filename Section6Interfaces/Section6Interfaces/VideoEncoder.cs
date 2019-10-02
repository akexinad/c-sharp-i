using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }

    // Now with the above interface, we can create our concrete implementations
        // which could vary from email, sms or logging a notification to the console.

    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail...");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    public class Message
    {
    }

    public class VideoEncoder
    {
        // Instead of using a concrete mailservice, we should use an interface as it makes our
        // code more testable and follows the principles of OCP.
        
        // private readonly MailService _mailService;

        
        // Given that there are multiple ways of notifying the user, we will need a list of notification channels.
        // With this, we have achieved OCP
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in _notificationChannels)
            {
                // THIS WHERE THE POLYMORPHIC BEHAVIOUR HAPPENS
                // When we instantiate the VideoEncoder class and call this function passing in various
                    // notification channels, the
                channel.Send(new Message());
            }
        }

        // We need to tell video encoder of all the existing notification channels at runtime.
        // We call this method when we want to let the concrete implementation of this class know
            // what notification channel we are using. 
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

    }



    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Mail was sent!");
        }
    }

    public class Video
    {
        public Video()
        {

        }
    }

    public class Mail
    {
        public Mail()
        {

        }
    }
}
