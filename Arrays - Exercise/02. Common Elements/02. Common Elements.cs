string[] firstLine = Console.ReadLine()
    .Split()
    .ToArray();
string[] secondLine = Console.ReadLine()
    .Split()
    .ToArray();

for (int i = 0; i < secondLine.Length; i++)
{
    for (int k = 0; k < firstLine.Length; k++)
    {
        if (firstLine[k] == secondLine[i])
        {
            Console.Write(secondLine[i] + " ");
        }
    }
}