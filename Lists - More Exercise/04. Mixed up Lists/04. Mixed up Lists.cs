List<int> firstLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

List<int> modifiedList = new List<int>();
List<int> modified = new List<int>();

while (firstLine.Count != 0 && secondLine.Count != 0)
{
    modifiedList.Add(firstLine[0]);
    modifiedList.Add(secondLine[secondLine.Count - 1]);

    firstLine.RemoveAt(0);
    secondLine.RemoveAt(secondLine.Count - 1);
}


if (firstLine.Count > secondLine.Count)
{
    int max = firstLine.Max();
    int min = firstLine.Min();

    for (int i = 0; i < modifiedList.Count; i++)
    {
        if (modifiedList[i] > min && modifiedList[i] < max)
        {
            modified.Add(modifiedList[i]);
        }
    }
}
else
{
    int max = secondLine.Max();
    int min = secondLine.Min();

    for (int i = 0; i < modifiedList.Count; i++)
    {
        if (modifiedList[i] > min && modifiedList[i] < max)
        {
            modified.Add(modifiedList[i]);
        }
    }
}
modified.Sort();
Console.WriteLine(string.Join(" ", modified));