using System;

namespace NotificationSystem
{

    public class PushNotification : INotification
    {
        private readonly string _deviceToken;

        public PushNotification(string deviceToken = "device-token-xyz")
        {
            _deviceToken = deviceToken;
        }

        public void Send(string message)
        {
            Console.WriteLine($"[PUSH to {_deviceToken}] Sending: {message}");
        }
    }
}
