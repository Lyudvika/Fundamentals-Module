List<string> treasure = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
string input;

while ((input = Console.ReadLine()) != "Yohoho!")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];

    if (cmdType == "Loot")
    {
        for (int i = 1; i < cmdArr.Length; i++)
        {
            if (treasure.Contains(cmdArr[i]))
            {
                continue;
            }
            treasure.Insert(0, cmdArr[i]);
        }
    }
    else if (cmdType == "Drop")
    {
        int index = int.Parse(cmdArr[1]);

        if (index < 0 || index >= treasure.Count)
        {
            continue;
        }

        string loot = treasure[index];
        treasure.RemoveAt(index);
        treasure.Add(loot);
    }
    else
    {
        List<string> stolenItems = new List<string>();
        int count = int.Parse(cmdArr[1]);
        if (count > treasure.Count)
        {
            count = treasure.Count;
        }

        for (int i = 0; i < count; i++)
        {
            stolenItems.Add(treasure[treasure.Count - 1]);
            treasure.RemoveAt(treasure.Count - 1);
        }
        stolenItems.Reverse();
        Console.WriteLine(string.Join(", ", stolenItems));
    }
}

if (treasure.Count == 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    int sum = 0;
    foreach (string name in treasure)
    {
        sum += name.Length;
    }
    Console.WriteLine($"Average treasure gain: {(decimal)sum/treasure.Count:f2} pirate credits.");
}