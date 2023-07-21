double budget = double.Parse(Console.ReadLine());
string game;
double budgetLeft = budget;

while ((game = Console.ReadLine()) != "Game Time")
{
    double price = 0;
    if (game == "OutFall 4")
    {
        price = 39.99;
        if (budgetLeft >= price)
        {
            Console.WriteLine("Bought OutFall 4");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "CS: OG")
    {
        price = 15.99;
        if (budgetLeft >= price)
        {
            Console.WriteLine("Bought CS: OG");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "Zplinter Zell")
    {
        price = 19.99;
        if (budgetLeft >= price)
        {
            Console.WriteLine("Bought Zplinter Zell");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "Honored 2")
    {
        price = 59.99;
        if (budgetLeft >= price)
        {
            Console.WriteLine("Bought Honored 2");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "RoverWatch")
    {
        price = 29.99;
        if (budgetLeft >= price)
        {
            Console.WriteLine("Bought RoverWatch");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (game == "RoverWatch Origins Edition")
    {
        price = 39.99;
        if (budget >= price)
        {
            Console.WriteLine("Bought RoverWatch Origins Edition");
            budgetLeft -= price;
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }

    if (budgetLeft == 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }
}
if (budgetLeft > 0)
{
    Console.WriteLine($"Total spent: ${budget - budgetLeft:f2}. Remaining: ${budgetLeft:f2}");
}