internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] tribonacci = new int[n];

        CalculatingTribonacciSequence(tribonacci);
    }

    private static void CalculatingTribonacciSequence(int[] tribonacci)
    {
        tribonacci[0] = 1;
        if (tribonacci.Length > 1)
        {
            tribonacci[1] = 1;
        }
        if (tribonacci.Length > 2)
        {
            tribonacci[2] = 2;
        }

        for (int i = 3; i < tribonacci.Length; i++)
        {
            tribonacci[i] = tribonacci[i-1] + tribonacci[i-2] + tribonacci[i-3];
        }

        for (int i = 0; i < tribonacci.Length; i++)
        {
            Console.Write(tribonacci[i] + " ");
        }
    }
}