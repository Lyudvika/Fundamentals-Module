using System.Diagnostics.CodeAnalysis;

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int magicNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < input.Length; i++)
{
    for (int k = 1 + i; k < input.Length; k++)
    {
        if (input[i] + input[k] == magicNumber)
        {
            Console.WriteLine(input[i] + " " + input[k]);
        }
    }
}