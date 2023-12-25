namespace FP.Patterns.Bridge
{
    internal class CImplementation3 : IBridge
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
            Console.WriteLine("Meeto total is ${0}, {1}% of total", totalM, totalM / total * 100);
            Console.WriteLine("Chicken total is ${0}, {1}% of total", totalC, totalC / total * 100);
            Console.WriteLine("Dairy total is ${0}, {1}% of total", totalD, totalD / total * 100);

            Console.WriteLine("Total of {0} products is {1}", count, total);
        }

        public void ListProducts(Dictionary<string, double> pProducts)
        {
            foreach (KeyValuePair<string, double> product in pProducts)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (product.Key.StartsWith("C"))
                {
                    Console.WriteLine("{0}: ${1}", product.Key, product.Value);
                }
            }

            foreach (KeyValuePair<string, double> product in pProducts)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (product.Key.StartsWith("M"))
                {
                    Console.WriteLine("{0}: ${1}", product.Key, product.Value);
                }
            }

            foreach (KeyValuePair<string, double> product in pProducts)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (product.Key.StartsWith("D"))
                {
                    Console.WriteLine("{0}: ${1}", product.Key, product.Value);
                }
            }
        }
    }
}
