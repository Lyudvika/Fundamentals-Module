List<int> seqOfTargets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];
    int index = int.Parse(cmdArr[1]);

    if (cmdType == "Shoot")
    {
        int power = int.Parse(cmdArr[2]);

        if (index >= seqOfTargets.Count || index < 0)
        {
            continue;
        }

        if (seqOfTargets[index] - power <= 0)
        {
            seqOfTargets.RemoveAt(index);
        }
        else
        {
            seqOfTargets[index] -= power;
        }
    }
    else if (cmdType == "Add")
    {
        int value = int.Parse(cmdArr[2]);

        if (index >= seqOfTargets.Count || index < 0)
        {
            Console.WriteLine("Invalid placement!");
            continue;
        }

        seqOfTargets.Insert(index, value);
    }
    else
    {
        int radius = int.Parse(cmdArr[2]);

        if (index >= seqOfTargets.Count || index < 0)
        {
            Console.WriteLine("Strike missed!");
            continue;
        }

        if (index + radius >= seqOfTargets.Count || index - radius < 0)
        {
            Console.WriteLine("Strike missed!");
            continue;
        }

        int targetsToRemove = 2 * radius + 1;
        while (targetsToRemove > 0)
        {
            seqOfTargets.RemoveAt(index - radius);
            targetsToRemove--;
        }
    }
}

Console.WriteLine(string.Join("|", seqOfTargets));