var contestsAndPasswords = new Dictionary<string, string>();
string inputLine;
while ((inputLine = Console.ReadLine()) != "end of contests")
{
    string[] cmdArg = inputLine.Split(":");
    string contest = cmdArg[0];
    string password = cmdArg[1];

    if (!contestsAndPasswords.ContainsKey(contest))
    {
        contestsAndPasswords.Add(contest, password);
    }
}

var rankings = new Dictionary<string, Dictionary<string, int>>(); //name, contest + points
var individualRanking = new Dictionary<string, int>();  //name, points

while ((inputLine = Console.ReadLine()) != "end of submissions")
{
    string[] cmdArg = inputLine.Split("=>");
    string contest = cmdArg[0];
    string password = cmdArg[1];
    string username = cmdArg[2];
    int points = int.Parse(cmdArg[3]);

    if (!contestsAndPasswords.ContainsKey(contest) || !contestsAndPasswords.ContainsValue(password))
    {
        continue;
    }

    if (!rankings.ContainsKey(username))
    {
        rankings.Add(username, new Dictionary<string, int>());
        rankings[username].Add(contest, points);

        individualRanking.Add(username, points);
    }
    else if (!rankings[username].ContainsKey(contest))
    {
        rankings[username].Add(contest, points);
        individualRanking[username] += points;
    }
    else if (rankings[username][contest] < points)
    {
        individualRanking[username] -= rankings[username][contest];
        individualRanking[username] += points;

        rankings[username][contest] = points;
    }
}

foreach (var item in individualRanking.OrderByDescending(x => x.Value).Take(1))
{
    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
}

Console.WriteLine("Ranking:");
foreach (var item in rankings.OrderBy(x => x.Key))
{
    Console.WriteLine(item.Key);
    Dictionary<string, int> contentAndPoints = item.Value;
    foreach (var info in contentAndPoints.OrderByDescending(y => y.Value))
    {
        Console.WriteLine($"#  {info.Key} -> {info.Value}");
    }
}