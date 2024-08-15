namespace FP.Patterns.Bridge.Exercice5
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string type)
        {
            Console.WriteLine($"Vector rendering a {type}");
        }
    }
}
