namespace FP.Patterns.Bridge.Exercice4
{
    public abstract class Content
    {
        protected IPublisher _publisher;

        protected Content(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public abstract void Publish();
    }
}
