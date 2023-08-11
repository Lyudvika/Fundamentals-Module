using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int repeatingTimes = int.Parse(Console.ReadLine());

        RepeatingWord(word, repeatingTimes);
    }

    private static void RepeatingWord(string word, int repeatingTimes)
    {
        for (int i = 1; i <= repeatingTimes; i++)
        {
            Console.Write(word);
        }
    }
}