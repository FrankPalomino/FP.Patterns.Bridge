namespace FP.Patterns.Bridge
{
    internal interface IBridge
    {
        void ShowTotals(Dictionary<string, double> pProducts);
        void ListProducts(Dictionary<string, double> pProducts);
    }
}
