namespace FP.Patterns.Bridge.Exercice5
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string type)
        {
            Console.WriteLine($"Raster rendering a {type}");
        }
    }
}
