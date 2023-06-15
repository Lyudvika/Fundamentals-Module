namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orders = new Dictionary<string, List<double>>();
            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArg = command.Split();
                string productName = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                double quantity = double.Parse(cmdArg[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, new List<double>());
                    orders[productName].Add(price);
                    orders[productName].Add(quantity);
                }
                else
                {
                    orders[productName][0] = price;
                    orders[productName][1] += quantity;
                }
            }

            foreach (var item in orders)
            {
                string productName = item.Key;
                List<double> price = item.Value;
                double sum = price[0] * price[1];
                Console.WriteLine($"{productName} -> {sum:f2}");
            }
        }
    }
}