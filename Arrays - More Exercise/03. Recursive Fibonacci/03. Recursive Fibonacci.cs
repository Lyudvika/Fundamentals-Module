long n = long.Parse(Console.ReadLine());
long[] fubonacci = new long[n];
fubonacci[0] = 1;

if (n > 1)
{
    fubonacci[1] = 1;
}

for (int i = 1;i < fubonacci.Length - 1; i++)
{
    fubonacci[i + 1] = fubonacci[i] + fubonacci[i - 1];
}

Console.WriteLine(fubonacci[n - 1]);