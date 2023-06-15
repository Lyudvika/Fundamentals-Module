namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var synonums = new Dictionary<string, List<string>>();

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonum = Console.ReadLine();

                if (!synonums.ContainsKey(word))
                {
                    synonums.Add(word, new List<string>());
                }

                synonums[word].Add(synonum);
            }

            foreach (var item in synonums)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}