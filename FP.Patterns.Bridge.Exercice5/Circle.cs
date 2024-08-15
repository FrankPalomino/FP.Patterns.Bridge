namespace FP.Patterns.Bridge.Exercice5
{
    public class Circle : Shape
    {
        public Circle(IRenderer render) : base(render)
        {
        }

        public override void Render()
        {
            _render.Render("Circle");
        }
    }
}
