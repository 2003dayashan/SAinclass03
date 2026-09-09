namespace NotificationSystem
{

    public class PushFactory : NotificationFactory
    {
        protected override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
