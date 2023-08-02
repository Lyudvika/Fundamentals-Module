var typesOfDragons = new Dictionary<string, SortedDictionary<string, List<int>>>();       //dragonColour -> dragonName && dmg[0] health[1] armor[2]

int inputCount = int.Parse(Console.ReadLine());

for (int i = 0; i < inputCount; i++)
{
    string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string dragonColor = cmdArg[0];
    string dragonName = cmdArg[1];
    int dragonDmg = cmdArg[2] == "null" ? 45 : int.Parse(cmdArg[2]);
    int dragonHealth = cmdArg[3] == "null" ? 250 : int.Parse(cmdArg[3]);
    int dragonArmor = cmdArg[4] == "null" ? 10 : int.Parse(cmdArg[4]);

    if (!typesOfDragons.ContainsKey(dragonColor))
    {
        typesOfDragons.Add(dragonColor, new SortedDictionary<string, List<int>>());
    }
    if (!typesOfDragons[dragonColor].ContainsKey(dragonName))
    {
        typesOfDragons[dragonColor].Add(dragonName, new List<int>());
        typesOfDragons[dragonColor][dragonName].Add(dragonDmg);
        typesOfDragons[dragonColor][dragonName].Add(dragonHealth);
        typesOfDragons[dragonColor][dragonName].Add(dragonArmor);
    }
    else
    {
        typesOfDragons[dragonColor][dragonName][0] = dragonDmg;
        typesOfDragons[dragonColor][dragonName][1] = dragonHealth;
        typesOfDragons[dragonColor][dragonName][2] = dragonArmor;
    }
}

foreach (var dragonType in typesOfDragons)
{
    double avarageDmg = 0;
    double avarageHealth = 0;
    double avarageArmor = 0;

    foreach (var drg in dragonType.Value)
    {
        avarageDmg += drg.Value[0];
        avarageHealth += drg.Value[1];
        avarageArmor += drg.Value[2];
    }

    Console.WriteLine($"{dragonType.Key}::({avarageDmg / dragonType.Value.Count():f2}/{avarageHealth / dragonType.Value.Count():f2}/{avarageArmor / dragonType.Value.Count():f2})");
    foreach (var dragon in dragonType.Value)
    {
        Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
    }
}