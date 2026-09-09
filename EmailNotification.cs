using System;

namespace NotificationSystem
{

    public class EmailNotification : INotification
    {
        private readonly string _senderAddress;

        public EmailNotification(string senderAddress = "no-reply@company.com")
        {
            _senderAddress = senderAddress;
        }

        public void Send(string message)
        {
            Console.WriteLine($"[EMAIL from {_senderAddress}] Sending: {message}");
        }
    }
}
