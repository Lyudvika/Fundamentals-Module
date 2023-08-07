List<int> firstPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> secondPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
{
    if (firstPlayer[0] > secondPlayer[0])
    {
        firstPlayer.Add(secondPlayer[0]);
        firstPlayer.Add(firstPlayer[0]);
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);
    }
    else if (firstPlayer[0] < secondPlayer[0])
    {
        secondPlayer.Add(firstPlayer[0]);
        secondPlayer.Add(secondPlayer[0]);
        secondPlayer.RemoveAt(0);
        firstPlayer.RemoveAt(0);
    }
    else
    {
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);
    }
}

int sum = 0;

if (firstPlayer.Count != 0)
{
    foreach (int card in firstPlayer) 
    { 
        sum+= card;
    }
    Console.WriteLine($"First player wins! Sum: {sum}");
}
else
{
    foreach (int card in secondPlayer)
    {
        sum += card;
    }
    Console.WriteLine($"Second player wins! Sum: {sum}");
}