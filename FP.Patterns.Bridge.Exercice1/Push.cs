namespace FP.Patterns.Bridge.Exercice1
{
    internal class Push : INotification
    {
        public void Notify(string message)
        {
            System.Console.WriteLine($"Sending Push: {message}");
        }
    }
}
