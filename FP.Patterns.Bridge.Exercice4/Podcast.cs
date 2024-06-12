namespace FP.Patterns.Bridge.Exercice4
{
    public class Podcast : Content
    {
        public string Title { get; set; }
        public string Transcript { get; set; }
        public Podcast(IPublisher publisher, string title, string transcript) : base(publisher)
        {
            Title = title;
            Transcript = transcript;
        }

        public override void Publish()
        {
            _publisher.Publish($"Article: {Title}\n{Transcript}");
        }
    }
}
