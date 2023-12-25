namespace FP.Patterns.Bridge.Exercice1
{
    internal class Email : INotification
    {
        public void Notify(string message)
        {
            System.Console.WriteLine($"Sending Email: {message}");
        }
    }
}
