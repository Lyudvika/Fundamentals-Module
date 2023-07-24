var piratesInfo = new Dictionary<string, List<int>>();
string command;

while ((command = Console.ReadLine()) != "Sail")
{
    string[] cmdArg = command.Split("||");
    string city = cmdArg[0];
    int population = int.Parse(cmdArg[1]);
    int gold = int.Parse(cmdArg[2]); 

    if (!piratesInfo.ContainsKey(city))
    {
        piratesInfo.Add(city, new List<int>() { population, gold });
    }
    else
    {
        piratesInfo[city][0] += population;
        piratesInfo[city][1] += gold;
    }
}

while ((command = Console.ReadLine()) != "End")
{
    string[] cmdArg = command.Split("=>");
    string cmdType = cmdArg[0];
    string town = cmdArg[1];

    if (cmdType == "Plunder")
    {
        int people = int.Parse(cmdArg[2]);
        int gold = int.Parse(cmdArg[3]);

        piratesInfo[town][0] -= people;
        piratesInfo[town][1] -= gold;
        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

        if (piratesInfo[town][0] <= 0 || piratesInfo[town][1] <= 0)
        {
            piratesInfo.Remove(town);
            Console.WriteLine($"{town} has been wiped off the map!");
        }
    }
    else if (cmdType == "Prosper") 
    {
        int gold = int.Parse(cmdArg[2]);

        if (gold <= 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
            continue;
        }

        piratesInfo[town][1] += gold;
        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {piratesInfo[town][1]} gold.");
    }
}

if (piratesInfo.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {piratesInfo.Count()} wealthy settlements to go to:");

    foreach (var item in piratesInfo)
    {
        string townName = item.Key;
        List<int> populationAndGold = item.Value;

        Console.WriteLine($"{townName} -> Population: {populationAndGold[0]} citizens, Gold: {populationAndGold[1]} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}