var dwarfs = new Dictionary<string, Dictionary<string, int>>();  //name, hatColour + physics

string inputLine;
while ((inputLine = Console.ReadLine()) != "Once upon a time")
{
    string[] cmdArg = inputLine.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
    string dwarfName = cmdArg[0];
    string dwarfHatColor = cmdArg[1];
    int dwarfPhysics = int.Parse(cmdArg[2]);

    if (!dwarfs.ContainsKey(dwarfName))
    {
        dwarfs.Add(dwarfName, new Dictionary<string, int>());
        dwarfs[dwarfName].Add(dwarfHatColor, dwarfPhysics);
    }
    else if (!dwarfs[dwarfName].ContainsKey(dwarfHatColor))
    {
        dwarfs[dwarfName].Add(dwarfHatColor, dwarfPhysics);
    }
    else if (dwarfs[dwarfName][dwarfHatColor] < dwarfPhysics)
    {
        dwarfs[dwarfName][dwarfHatColor] = dwarfPhysics;
    }
}

var sortedEntries = dwarfs
    .SelectMany(kv1 => kv1.Value.Select(kv2 => new { Name = kv1.Key, Color = kv2.Key, Points = kv2.Value }))
    .OrderByDescending(entry => entry.Points)
    .ThenBy(entry => dwarfs.Sum(kv => kv.Value.ContainsKey(entry.Color) ? 0 : 1));

foreach (var entry in sortedEntries)
{
    Console.WriteLine($"({entry.Color}) {entry.Name} <-> {entry.Points}");
}