namespace FP.Patterns.Bridge.Exercice4
{
    public class Article : Content
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Article(IPublisher publisher, string title, string body) : base(publisher)
        {
            Title = title;
            Body = body;
        }

        public override void Publish()
        {
            _publisher.Publish($"Article: {Title}\n{Body}");
        }
    }
}
