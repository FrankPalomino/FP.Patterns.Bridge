using FP.Patterns.Bridge.Exercice5;

IRenderer vectorRender = new VectorRenderer();
Shape circle = new Circle(vectorRender);
Shape rectangle = new Rectangle(vectorRender);
circle.Render();
rectangle.Render();

Console.WriteLine("-----------------------");

IRenderer rasterRender = new RasterRenderer();
Shape circle2 = new Circle(rasterRender);
Shape rectangle2 = new Rectangle(rasterRender);
circle2.Render();
rectangle2.Render();