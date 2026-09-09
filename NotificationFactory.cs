using System;

namespace NotificationSystem
{

    public abstract class NotificationFactory
    {

        protected abstract INotification CreateNotification();


        public void Notify(string message)
        {
            INotification notification = CreateNotification();

            LogDispatch();
            notification.Send(message);
        }

        protected void LogDispatch()
        {
            Console.WriteLine($"-- Dispatching via {GetType().Name} --");
        }
    }
}
