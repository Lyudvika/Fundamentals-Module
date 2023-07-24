int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
int houseCupidIsAt = 0;
int houses = neighborhood.Length;
string input;

while ((input = Console.ReadLine()) != "Love!")
{
    string[] cmdArr = input.Split();
    int length = int.Parse(cmdArr[1]);
    houseCupidIsAt+= length;

    if (houseCupidIsAt >= neighborhood.Length)
    {
        houseCupidIsAt = 0;
    }

    if (neighborhood[houseCupidIsAt] <= 0)
    {
        Console.WriteLine($"Place {houseCupidIsAt} already had Valentine's day.");
        continue;
    }
    else if (neighborhood[houseCupidIsAt] - 2 <= 0)
    {
        neighborhood[houseCupidIsAt] -= 2;
        houses--;
        Console.WriteLine($"Place {houseCupidIsAt} has Valentine's day.");
        continue;
    }
    neighborhood[houseCupidIsAt] -= 2;
}

bool allHousesHadVal = true;
Console.WriteLine($"Cupid's last position was {houseCupidIsAt}.");

foreach (int house in neighborhood)
{
    if (house > 0)
    {
        allHousesHadVal = false;
        break;
    }
}

if (allHousesHadVal)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {houses} places.");
}
