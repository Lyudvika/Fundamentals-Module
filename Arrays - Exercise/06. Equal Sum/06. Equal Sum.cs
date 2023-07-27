int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sumOfLeft = 0;
int sumOfRight = 0;

if (input.Length == 1)
{
    Console.WriteLine(0);
    return;
}

for (int i = 0; i < input.Length; i++)
{
    sumOfLeft = 0;
    for (int l = i - 1; l >= 0; l--)
    {
        sumOfLeft += input[l];
    }

    sumOfRight = 0;
    for (int r = i + 1; r < input.Length; r++)
    {
        sumOfRight += input[r];
    }
    if (sumOfLeft == sumOfRight)
    {
        Console.WriteLine(i);
        return;
    }
}

Console.WriteLine("no");