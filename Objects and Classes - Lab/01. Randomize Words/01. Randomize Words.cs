using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, input.Length);
            string currWord = input[i];
            string nextWord = input[randomIndex];
            input[i] = nextWord;
            input[randomIndex] = currWord;
        }

        Console.WriteLine(string.Join("\n", input));
    }
}