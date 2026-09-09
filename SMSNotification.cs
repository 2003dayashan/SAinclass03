using System;

namespace NotificationSystem
{

    public class SMSNotification : INotification
    {
        private readonly string _gatewayNumber;

        public SMSNotification(string gatewayNumber = "+94-77-000-0000")
        {
            _gatewayNumber = gatewayNumber;
        }

        public void Send(string message)
        {
            Console.WriteLine($"[SMS via {_gatewayNumber}] Sending: {message}");
        }
    }
}
