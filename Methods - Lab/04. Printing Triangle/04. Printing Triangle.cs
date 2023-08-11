internal class Program
{
    private static void Main(string[] args)
    {
        TriangleNumber(int.Parse(Console.ReadLine()));
    }

    static void TriangleNumber(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        for (int i = number; i >= 1; i--)
        {
            for (int j = 1; j <= i - 1; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}