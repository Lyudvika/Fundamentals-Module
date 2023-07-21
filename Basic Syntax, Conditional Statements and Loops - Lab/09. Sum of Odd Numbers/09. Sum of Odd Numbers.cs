int n = int.Parse(Console.ReadLine());

int numberSum = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * 2 - 1);
    numberSum += i * 2 - 1;
}

Console.WriteLine($"Sum: {numberSum}");