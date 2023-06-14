internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        GetStringSum(names[0], names[1]);
    }

    private static void GetStringSum(string stringOne, string stringTwo)
    {
        int sum = 0;
        int minLength = Math.Min(stringOne.Length, stringTwo.Length);
        for (int i = 0; i < minLength; i++)
        {
            sum += stringOne[i] * stringTwo[i];
        }

        string longestLengthString = stringOne;
        if (longestLengthString.Length < stringTwo.Length)
        {
            longestLengthString = stringTwo;
        }
        for (int i = minLength; i < longestLengthString.Length; i++)
        {
            sum += longestLengthString[i];
        }
        Console.WriteLine(sum);
    }
}