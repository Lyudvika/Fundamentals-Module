var plantDiscovery = new Dictionary<string, List<int>>();
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string[] cmdArd = Console.ReadLine().Split("<->");
    string plant = cmdArd[0];
    int rarity = int.Parse(cmdArd[1]);

    if (!plantDiscovery.ContainsKey(plant))
    {
        plantDiscovery.Add(plant, new List<int>());
        plantDiscovery[plant].Add(rarity);
    }
    else 
    {
        plantDiscovery[plant].RemoveAt(0);
        plantDiscovery[plant].Add(rarity);
    }
}

string command;

while ((command = Console.ReadLine()) != "Exhibition")
{
    string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArg[0];
    string plant = cmdArg[1];

    if (!plantDiscovery.ContainsKey(plant))
    {
        Console.WriteLine("error");
        continue;
    }

    if (cmdType == "Rate:")
    {
        int rating = int.Parse(cmdArg[3]);

        plantDiscovery[plant].Add(rating);
    }
    else if (cmdType == "Update:")
    {
        int newRarity = int.Parse(cmdArg[3]);

        plantDiscovery[plant].RemoveAt(0);
        plantDiscovery[plant].Insert(0, newRarity);
    }
    else if (cmdType == "Reset:")
    {
        int length = plantDiscovery[plant].Count;
        if (length > 1)
        {
            plantDiscovery[plant].RemoveRange(1, length - 1);
        }
    }
}

Console.WriteLine("Plants for the exhibition:");

foreach (var item in plantDiscovery)
{
    string plantName = item.Key;
    List<int> ratings = item.Value;
    int sum = 0;

    for (int i = 1; i < ratings.Count; i++)
    {
        sum += ratings[i];
    }

    if (ratings.Count - 1 <= 0 || sum == 0)
    {
        Console.WriteLine($"- {plantName}; Rarity: {ratings[0]}; Rating: 0.00");
        continue;
    }
    Console.WriteLine($"- {plantName}; Rarity: {ratings[0]}; Rating: {(double)sum / (ratings.Count - 1):f2}");
}