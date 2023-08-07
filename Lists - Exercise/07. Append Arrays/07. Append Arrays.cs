List<string> arr = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
List<string> result = new List<string>();

for (int i = 0;i < arr.Count; i++)
{
    string[] arr2 = arr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int k = 0; k < arr2.Length; k++)
    {
        result.Add(arr2[k]);
    }
}

Console.WriteLine(string.Join(" ", result));