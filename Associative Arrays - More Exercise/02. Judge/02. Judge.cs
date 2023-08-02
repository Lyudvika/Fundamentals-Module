var individualStatistics = new Dictionary<string, int>();//name, points
var statistics = new Dictionary<string, Dictionary<string, int>>();//contest, name & points

string inputLine;
while ((inputLine = Console.ReadLine()) != "no more time")
{
    string[] cmdArg = inputLine.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string name = cmdArg[0];
    string contest = cmdArg[1];
    int points = int.Parse(cmdArg[2]);

    if (!statistics.ContainsKey(contest)) //if contest doesnt exist in the dict
    {
        statistics.Add(contest, new Dictionary<string, int>());
        statistics[contest].Add(name, points);

        if (!individualStatistics.ContainsKey(name))
        {
            individualStatistics.Add(name, points);
        }
        else
        {
            individualStatistics[name] += points;
        }
    }
    else if (!statistics[contest].ContainsKey(name)) //if the contest exist, but the person isnt in it yet
    {
        statistics[contest].Add(name, points);

        if (!individualStatistics.ContainsKey(name))  //if the person isnt already in the dict from another contest
        {
            individualStatistics.Add(name, points);
        }
        else
        {
            individualStatistics[name] += points;
        }
    }
    else if (statistics[contest][name] < points)  //if the contests and person already exist but has different points
    {
        individualStatistics[name] -= statistics[contest][name];  //removing the old points
        individualStatistics[name] += points; //adding the new ones

        statistics[contest][name] = points; //setting the points to the new one
    }
}

int index = 1;
foreach (var item in statistics)
{
    index = 1;
    Dictionary<string, int> nameAndPoints = item.Value;
    Console.WriteLine($"{item.Key}: {nameAndPoints.Count} participants");
    foreach (var stat in nameAndPoints.OrderByDescending(z => z.Value).ThenBy(z => z.Key))
    {
        Console.WriteLine($"{index++}. {stat.Key} <::> {stat.Value}");
    }
}

Console.WriteLine("Individual standings:");
index = 1;
foreach (var item in individualStatistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{index++}. {item.Key} -> {item.Value}");
}