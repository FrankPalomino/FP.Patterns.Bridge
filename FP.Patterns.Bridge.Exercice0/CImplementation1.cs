namespace FP.Patterns.Bridge
{
    internal class CImplementation1 : IBridge
    {
        public void ShowTotals(Dictionary<string, double> pProducts)
        {
            double total = 0;
            int count = 0;

            foreach (KeyValuePair<string, double> product in pProducts)
            {
                total += product.Value;
                count++;
            }
            Console.WriteLine("Total of {0} products is {1}", count, total);
        }

        public void ListProducts(Dictionary<string, double> pProducts)
        {
            foreach (KeyValuePair<string, double> product in pProducts)
            {
                Console.WriteLine("{0}: {1}", product.Key, product.Value);
            }
        }
    }
}
