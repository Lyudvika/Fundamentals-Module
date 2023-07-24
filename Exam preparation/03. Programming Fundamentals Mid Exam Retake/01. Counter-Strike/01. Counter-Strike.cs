int energy = int.Parse(Console.ReadLine());
string input;

int wonBattles = 0;

while ((input = Console.ReadLine()) != "End of battle")
{
    int distance = int.Parse(input);

    if (energy - distance < 0)
    {
        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
        break;
    }

    energy -= distance;
    wonBattles++;

    if (wonBattles % 3 == 0)
    {
        energy += wonBattles;
    }
}

if (input == "End of battle")
{
    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
}