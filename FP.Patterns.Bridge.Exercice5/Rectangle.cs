namespace FP.Patterns.Bridge.Exercice5
{
    public class Rectangle : Shape
    {
        public Rectangle(IRenderer render) : base(render)
        {
        }

        public override void Render()
        {
            _render.Render("Rectangle");
        }
    }
}
