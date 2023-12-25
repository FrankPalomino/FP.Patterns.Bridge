namespace FP.Patterns.Bridge.Exercice1
{
    internal class Sms : INotification
    {
        public void Notify(string message)
        {
            System.Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
