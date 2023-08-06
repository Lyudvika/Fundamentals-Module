double n = long.Parse(Console.ReadLine());
double sum = 0;

for (int i = 1; i <= n; i++)
{
    double number = long.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);