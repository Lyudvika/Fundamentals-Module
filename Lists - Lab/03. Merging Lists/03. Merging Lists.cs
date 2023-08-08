List<int> firstRow = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondRow = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> combinationOfBothLists = new List<int>();

int n = Math.Min(firstRow.Count, secondRow.Count);
for (int i = 0; i < n; i++)
{
    combinationOfBothLists.Add(firstRow[i]);
    combinationOfBothLists.Add(secondRow[i]);
}
if (firstRow.Count > secondRow.Count)
{
    for (int i = n; i < firstRow.Count; i++)
    {
        combinationOfBothLists.Add(firstRow[i]);
    }
}
else
{
    for (int i = n; i < secondRow.Count; i++)
    {
        combinationOfBothLists.Add(secondRow[i]);
    }
}

Console.WriteLine(string.Join(" ", combinationOfBothLists));