int numberOfCommands = int.Parse(Console.ReadLine());
List<string> guestParty = new List<string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] cmdArg = Console.ReadLine().Split().ToArray();
    string name = cmdArg[0];

    if (cmdArg.Length == 3)
    {
        if (guestParty.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }

        guestParty.Add(name);
    }
    else if (cmdArg.Length == 4)
    {
        if (guestParty.Contains(name))
        {
            guestParty.Remove(name);
            continue;
        }

        Console.WriteLine($"{name} is not in the list!");
    }
}

Console.WriteLine(string.Join(Environment.NewLine, guestParty));