namespace FP.Patterns.Bridge.Exercice4
{
    public class MobileAppPublisher : IPublisher
    {
        public void Publish(string content)
        {
            Console.WriteLine($"Publishing on mobile app: {content}");
        }
    }
}
