using System.Threading;

string[] dungen = Console.ReadLine().Split("|").ToArray();
int health = 100;
int bitcoin = 0;
bool dead = false;
int room = 0;

for (int i = 0;i < dungen.Length; i++)
{
    string[] cmdArr = dungen[i].Split();
    string cmdType = cmdArr[0];
    int number = int.Parse(cmdArr[1]);
    room++;

    if (cmdType == "potion")
    {
        int healing = 0;
        if (health == 100)
        {
            Console.WriteLine($"You healed for {healing} hp.");
            Console.WriteLine($"Current health: {health} hp.");
            continue;
        }

        if (health + number > 100)
        {
            healing = number - (health + number - 100);
            health = 100;
        }
        else
        {
            healing = number;
            health += number;
        }

        Console.WriteLine($"You healed for {healing} hp.");
        Console.WriteLine($"Current health: {health} hp.");
    }
    else if (cmdType == "chest")
    {
        bitcoin += number;
        Console.WriteLine($"You found {number} bitcoins.");
    }
    else
    {
        if (health - number > 0)
        {
            health -= number;
            Console.WriteLine($"You slayed {cmdType}.");
        }
        else
        {
            Console.WriteLine($"You died! Killed by {cmdType}.");
            dead = true;
        }
    }

    if (dead)
    {
        break;
    }
}

if (dead)
{
    Console.WriteLine($"Best room: {room}");
}
else
{
    Console.WriteLine("You've made it!");
    Console.WriteLine($"Bitcoins: {bitcoin}");
    Console.WriteLine($"Health: {health}");
}