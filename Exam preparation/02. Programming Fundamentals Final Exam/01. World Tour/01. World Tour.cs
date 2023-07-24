string tour = Console.ReadLine();
string command;

while ((command = Console.ReadLine()) != "Travel")
{
    string[] cmdArg = command.Split(":");
    string cmdType = cmdArg[0];

    if (cmdType == "Add Stop")
    {
        int index = int.Parse(cmdArg[1]);
        string str = cmdArg[2];

        if (index < 0 || index >= tour.Length)
        {
            Console.WriteLine(tour);
            continue;
        }

        tour = tour.Insert(index, str);
        Console.WriteLine(tour);
    }
    else if (cmdType == "Remove Stop")
    {
        int startIndex = int.Parse(cmdArg[1]);
        int endIndex = int.Parse(cmdArg[2]);

        if (startIndex < 0 || startIndex >= tour.Length || endIndex < 0 || endIndex >= tour.Length)
        {
            Console.WriteLine(tour);
            continue;
        }

        tour = tour.Remove(startIndex, endIndex - startIndex + 1);//13 16 -> 13 + 3 + 1 -> 17
        Console.WriteLine(tour);
    }
    else if (cmdType == "Switch")
    {
        string oldStr = cmdArg[1];
        string newStr = cmdArg[2];

        if (tour.Contains(oldStr))
        {
            tour = tour.Replace(oldStr, newStr);
            Console.WriteLine(tour);
            continue;
        }
        Console.WriteLine(tour);
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {tour}");