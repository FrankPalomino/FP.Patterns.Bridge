namespace FP.Patterns.Bridge.Exercice4
{
    public class SocialMediaPublisher : IPublisher
    {
        public void Publish(string content)
        {
            Console.WriteLine($"Publishing on social media: {content}");
        }
    }
}
