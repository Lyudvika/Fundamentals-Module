int n = int.Parse(Console.ReadLine());
int[] firstLine = new int[n];
int[] secondLine = new int[n];

for (int i = 0;i < n; i++)
{
    int[] zigzagArray = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    if (i % 2 == 0)
    {
        secondLine[i] = zigzagArray[1];
        firstLine[i] = zigzagArray[0];
    }
    else
    {
        secondLine[i] = zigzagArray[0];
        firstLine[i] = zigzagArray[1];
    }
}

for (int i = 0;i < firstLine.Length; i++)
{
    Console.Write(firstLine[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < secondLine.Length; i++)
{
    Console.Write(secondLine[i] + " ");
}