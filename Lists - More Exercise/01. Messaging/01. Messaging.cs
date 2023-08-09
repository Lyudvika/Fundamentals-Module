internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string words = Console.ReadLine();
        List<string> output = new List<string>();
        List<char> test = words.ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            int count = numbers[i];
            int sum = 0;

            while (count > 0)
            {
                sum += count % 10;
                count /= 10;
            }

            if (sum >= test.Count)
            {
                sum -= test.Count;
            }

            char letter = test[sum];
            output.Add(letter.ToString());
            test.RemoveAt(sum);
        }
        Console.WriteLine(string.Join("", output));
    }
}