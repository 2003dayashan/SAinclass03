namespace NotificationSystem
{

    public class EmailFactory : NotificationFactory
    {
        protected override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
