namespace FP.Patterns.Bridge.Exercice1
{
    internal class ClientNotification
    {
        private readonly INotification _notification;

        public ClientNotification(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.Notify(message);
        }
    }
}
