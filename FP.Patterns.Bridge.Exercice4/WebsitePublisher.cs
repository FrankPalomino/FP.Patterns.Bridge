namespace FP.Patterns.Bridge.Exercice4
{
    public class WebsitePublisher : IPublisher
    {
        public void Publish(string content)
        {
            Console.WriteLine($"Publishing on website: {content}");
        }
    }
}
