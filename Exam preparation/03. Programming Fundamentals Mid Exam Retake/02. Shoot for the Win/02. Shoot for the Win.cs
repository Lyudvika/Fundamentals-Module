int[] targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int shotTargets = 0;
string input;

while ((input = Console.ReadLine()) != "End")
{
    int index = int.Parse(input);
    if (index >= targets.Length || index < 0)
    {
        continue;
    }

    shotTargets++;
    int numOfShotTarget = targets[index];

    for (int i = 0; i < targets.Length; i++)
    {
        if (targets[i] == -1)
        {
            continue;
        }

        if (targets[i] <= numOfShotTarget)
        {
            targets[i] += numOfShotTarget;
        }
        else
        {
            targets[i] -= numOfShotTarget;
        }
    }
    targets[index] = -1;
}

Console.Write($"Shot targets: {shotTargets} -> ");
Console.WriteLine(string.Join(" ", targets));