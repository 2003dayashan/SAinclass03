namespace NotificationSystem
{

    public class SMSFactory : NotificationFactory
    {
        protected override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
