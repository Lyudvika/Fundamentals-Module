namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToArray().Select(x => x.ToString()).ToArray();

            var frecuance = new Dictionary<string, int>();

            foreach (string ch in words)
            {
                if (ch == " ")
                {
                    continue;
                }

                if (!frecuance.ContainsKey(ch))
                {
                    frecuance.Add(ch, 0);
                }

                frecuance[ch]++;
            }

            foreach (var item in frecuance)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}