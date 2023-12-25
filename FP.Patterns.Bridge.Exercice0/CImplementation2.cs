namespace FP.Patterns.Bridge
{
    internal class CImplementation2 : IBridge
    {
        public void ShowTotals(Dictionary<string, double> pProducts)
        {
            double total = 0;
            double totalM = 0;
            double totalC = 0;
            double totalD = 0;
            int count = 0;

            foreach (KeyValuePair<string, double> product in pProducts)
            {
                total += product.Value;

                if (product.Key.StartsWith("M"))
                {
                    totalM += product.Value;
                }
                else if (product.Key.StartsWith("C"))
                {
                    totalC += product.Value;
                }
                else if (product.Key.StartsWith("D"))
                {
                    totalD += product.Value;
                }

                count++;
            }
            Console.WriteLine("Meet total is {0}", totalM);
            Console.WriteLine("Chicken total is {0}", totalC);
            Console.WriteLine("Dairy total is {0}", totalD);

            Console.WriteLine("Total of {0} products is {1}", count, total);
        }

        public void ListProducts(Dictionary<string, double> pProducts)
        {
            foreach (KeyValuePair<string, double> product in pProducts)
            {
                if (product.Key.StartsWith("C"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (product.Key.StartsWith("D"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (product.Key.StartsWith("M"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine("{0}: {1}", product.Key, product.Value);
            }
        }
    }
}
