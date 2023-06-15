namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();
            string command;

            while ((command = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!mine.ContainsKey(command))
                {
                    mine.Add(command, quantity);
                    continue;
                }
                mine[command] += quantity;
            }

            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}