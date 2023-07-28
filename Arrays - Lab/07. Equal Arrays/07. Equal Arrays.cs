using System;

int[] firstInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] secondInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int whereTheyDiffer = 0;
int sum = 0;

for (int i = 0;i < firstInput.Length; i++)
{
    if (firstInput[i] != secondInput[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {whereTheyDiffer} index");
        return;
    }
    else
    {
        sum += secondInput[i];
    }
    whereTheyDiffer++;
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");