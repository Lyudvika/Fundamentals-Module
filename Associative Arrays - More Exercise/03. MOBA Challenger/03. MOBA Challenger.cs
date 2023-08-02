Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, int> playerPoints = new Dictionary<string, int>();

string command;
string endCommand = "Season end";

while ((command = Console.ReadLine()) != endCommand)
{
    string[] cmdArg = command.Split(" -> ");

    if (cmdArg.Length != 1)
    {
        string player = cmdArg[0];
        string position = cmdArg[1];
        int skill = int.Parse(cmdArg[2]);

        if (!players.ContainsKey(player))
        {
            players.Add(player, new Dictionary<string, int>());
        }
        if (!players[player].ContainsKey(position))
        {
            players[player].Add(position, 0);
        }

        players[player][position] = Math.Max(players[player][position], skill);
    }
    else
    {
        cmdArg = command.Split(" vs ");
        string playerOne = cmdArg[0];
        string playerTwo = cmdArg[1];

        if (!players.ContainsKey(playerOne) || !players.ContainsKey(playerTwo))
        {
            continue;
        }

        bool haveInComman = false;
        int firstPlayerPoints = players[playerOne].Values.Sum();
        int secondPlayerPoints = players[playerTwo].Values.Sum();

        List<string> playerOnePositions = players[playerOne].Keys.ToList();
        List<string> playerTwoPositions = players[playerTwo].Keys.ToList();

        for (int i = 0; i < playerOnePositions.Count; i++)
        {
            if (playerTwoPositions.Contains(playerOnePositions[i]))
            {
                haveInComman = true;
            }
        }

        if (haveInComman)
        {
            if (firstPlayerPoints > secondPlayerPoints)
            {
                players.Remove(playerTwo);
            }
            else if (firstPlayerPoints < secondPlayerPoints)
            {
                players.Remove(playerOne);
            }
        }
    }
}



foreach (var player in players.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(n => n.Key))
{
    Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

    foreach (var positionSkill in player.Value.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
    {
        Console.WriteLine($"- {positionSkill.Key} <::> {positionSkill.Value}");
    }
}