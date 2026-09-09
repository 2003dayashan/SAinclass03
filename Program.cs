using System;
using System.Collections.Generic;

namespace NotificationSystem
{

    class Program
    {
        static void Main(string[] args)
        {
            List<NotificationFactory> factories = new List<NotificationFactory>
            {
                new EmailFactory(),
                new SMSFactory(),
                new PushFactory()
            };

            string[] messages =
            {
                "Your order has been shipped!",
                "Your OTP is 4521",
                "You have a new message"
            };

            for (int i = 0; i < factories.Count; i++)
            {
                factories[i].Notify(messages[i]);
                Console.WriteLine();
            }
        }
    }
}
