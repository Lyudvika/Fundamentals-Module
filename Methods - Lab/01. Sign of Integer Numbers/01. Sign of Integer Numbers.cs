internal class Program
{
    private static void Main(string[] args)
    {
        PositiveNegativeEqual(int.Parse(Console.ReadLine()));

    }
    static void PositiveNegativeEqual(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}