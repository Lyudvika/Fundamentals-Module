List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArg = input.Split();

    if (cmdArg.Length == 2)
    {
        int passengers = int.Parse(cmdArg[1]);

        trainWagons.Add(passengers);
    }
    else if (cmdArg.Length == 1)
    {
        int passengers = int.Parse(cmdArg[0]);
        for (int i = 0; i < trainWagons.Count; i++)
        {
            if (trainWagons[i] + passengers <= maxCapacity)
            {
                trainWagons[i] += passengers;
                break;
            }
        }
    }
}
Console.WriteLine(string.Join(" ", trainWagons));