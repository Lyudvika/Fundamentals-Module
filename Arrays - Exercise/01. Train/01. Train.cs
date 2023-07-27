int n = int.Parse(Console.ReadLine());
int[] personPerWagon = new int[n];

int sum = 0;

for (int i = 0; i < n; i++)
{
    personPerWagon[i] = int.Parse(Console.ReadLine());
    sum += personPerWagon[i];
}

for (int i = 0; i < n; i++)
{
    Console.Write(personPerWagon[i] + " ");
}

Console.WriteLine();
Console.WriteLine(sum);