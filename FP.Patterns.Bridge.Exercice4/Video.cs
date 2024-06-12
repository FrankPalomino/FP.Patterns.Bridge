namespace FP.Patterns.Bridge.Exercice4
{
    public class Video : Content
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Video(IPublisher publisher, string title, string description) : base(publisher)
        {
            Title = title;
            Description = description;
        }

        public override void Publish()
        {
            _publisher.Publish($"Article: {Title}\n{Description}");
        }
    }
}
