namespace FP.Patterns.Bridge.Exercice5
{
    public abstract class Shape
    {
        protected IRenderer _render;

        protected Shape(IRenderer render)
        {
            _render = render;
        }

        public abstract void Render();
    }
}
