int peopleWaitint = int.Parse(Console.ReadLine());
int[] liftSeats = Console.ReadLine().Split().Select(int.Parse).ToArray();

bool allseatsTaken = true;

for (int i = 0; i < liftSeats.Length; i++)
{
    while (peopleWaitint > 0)
    {
        if (liftSeats[i] < 4)
        {
            liftSeats[i] ++;
            peopleWaitint--;
        }
        else
        {
            break;
        }
    }
}

if (peopleWaitint > 0)
{
    Console.WriteLine($"There isn't enough space! {peopleWaitint} people in a queue!");
    Console.WriteLine(string.Join(" ", liftSeats));
}

else
{
    foreach (int seats in liftSeats)
    {
        if (seats != 4) 
        { 
            allseatsTaken= false;
        }
    }

    if (!allseatsTaken)
    {
        Console.WriteLine("The lift has empty spots!");
        Console.WriteLine(string.Join(" ", liftSeats));
    }
    else
    {
        Console.WriteLine(string.Join(" ", liftSeats));
    }
}
