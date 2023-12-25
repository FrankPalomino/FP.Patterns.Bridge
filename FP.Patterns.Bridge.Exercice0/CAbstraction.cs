namespace FP.Patterns.Bridge
{
    internal class CAbstraction
    {
        IBridge implementation;
        Dictionary<string, double> products;

        public CAbstraction(IBridge pImplementation, Dictionary<string, double> pProducts)
        {
            implementation = pImplementation;
            products = pProducts;
        }

        public CAbstraction(int pType, Dictionary<string, double> pProducts)
        {
            switch (pType)
            {
                case 1:
                    implementation = new CImplementation1();
                    break;
                case 2:
                    implementation = new CImplementation2();
                    break;
                case 3:
                    implementation = new CImplementation3();
                    break;
                default:
                    throw new Exception("Invalid type");
            }
            products = pProducts;
        }

        public void ShowTotals()
        {
            implementation.ShowTotals(products);
        }

        public void ListProducts()
        {
            implementation.ListProducts(products);
        }
    }
}
