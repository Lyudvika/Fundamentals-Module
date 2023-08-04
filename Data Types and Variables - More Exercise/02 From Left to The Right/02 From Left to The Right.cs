using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

for (int i =1; i <= n; i++)
{
    long[] inputNumbers = Console.ReadLine()
        .Split()
        .Select(long.Parse)
        .ToArray();
    long leftNumber = inputNumbers[0];
    long rightNumber = inputNumbers[1];
    long sum = 0;

    if (leftNumber >= rightNumber)
    {
        while (leftNumber != 0)
        {
            sum += leftNumber % 10;
            leftNumber /= 10;
        }
    }
    else
    {
        while (rightNumber != 0)
        {
            sum += rightNumber % 10;
            rightNumber /= 10;
        }
    }
    Console.WriteLine(Math.Abs(sum));
}