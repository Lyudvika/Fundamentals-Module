namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }

                counts[num]++;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}