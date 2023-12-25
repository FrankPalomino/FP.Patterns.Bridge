
using FP.Patterns.Bridge;

Dictionary<string, double> products = new Dictionary<string, double>
{
    { "M1O1", 56.32 },
    { "M234", 23.88 },
    { "C654", 974.56 },
    { "M401", 43.28 },
    { "C345", 785.12 },
    { "D567", 432.56 },
    { "D901", 874.54 },
    { "C732", 23.18 },
    { "M103", 43.12 },
    { "M056", 21.42 }
};

//CAbstraction bridge = new CAbstraction(new CImplementation1(), products);
//CAbstraction bridge = new CAbstraction(new CImplementation2(), products);
//CAbstraction bridge = new CAbstraction(new CImplementation3(), products);

//CAbstraction bridge = new CAbstraction(1, products);
//CAbstraction bridge = new CAbstraction(2, products);
CAbstraction bridge = new CAbstraction(3, products);


bridge.ShowTotals();
bridge.ListProducts();







