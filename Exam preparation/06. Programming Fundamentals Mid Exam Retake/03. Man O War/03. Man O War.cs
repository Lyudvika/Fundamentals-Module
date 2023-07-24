List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();        
List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
int maxHealth = int.Parse(Console.ReadLine());
string input;

bool youWon = false;
bool youLost = false;

while ((input = Console.ReadLine()) != "Retire")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];

    if (cmdType == "Fire")
    {
        int index = int.Parse(cmdArr[1]);
        int damage = int.Parse(cmdArr[2]);
        if (index >= warShip.Count || index < 0)
        {
            continue;
        }

        if (warShip[index] - damage <= 0)
        {
            Console.WriteLine("You won! The enemy ship has sunken.");
            return;
        }

        warShip[index] -= damage;
    }
    else if (cmdType == "Defend")
    {
        int startIndex = int.Parse(cmdArr[1]);
        int endIndex = int.Parse(cmdArr[2]);
        int damage = int.Parse(cmdArr[3]);

        if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] -= damage;
                if (pirateShip[i] < 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    return;
                }
            }
        }
    }
    else if (cmdType == "Repair")
    {
        int index = int.Parse(cmdArr[1]);
        int health = int.Parse(cmdArr[2]);

        if (index >= 0 && index < pirateShip.Count)
        {
            if (pirateShip[index] + health > maxHealth)
            {
                pirateShip[index] = maxHealth;
                continue;
            }

            pirateShip[index] += health;
        }
    }
    else if (cmdType == "Status")
    {
        int sectionsToRepair = 0;
        foreach (int section in pirateShip)
        {
            if (section < maxHealth * 0.2)
            {
                sectionsToRepair++;
            }
        }
        Console.WriteLine($"{sectionsToRepair} sections need repair.");
    }
}

int pirateShipSum = 0;
int warshipSum = 0;
foreach (int count in pirateShip)
{
    pirateShipSum += count;
}
foreach (int count in warShip)
{
    warshipSum += count;
}

Console.WriteLine($"Pirate ship status: {pirateShipSum}");
Console.WriteLine($"Warship status: {warshipSum}");