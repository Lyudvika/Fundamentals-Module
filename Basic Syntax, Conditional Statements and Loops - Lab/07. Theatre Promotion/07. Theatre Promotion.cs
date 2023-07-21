string typeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

if (age >= 0 && age <= 18)
{
    if (typeOfDay == "Weekday")
    {
        Console.WriteLine("12$");
    }
    else if (typeOfDay == "Weekend")
    {
        Console.WriteLine("15$");
    }
    else
    {
        Console.WriteLine("5$");
    }
}
else if (age > 18 && age <= 64)
{
    if (typeOfDay == "Weekday")
    {
        Console.WriteLine("18$");
    }
    else if (typeOfDay == "Weekend")
    {
        Console.WriteLine("20$");
    }
    else
    {
        Console.WriteLine("12$");
    }
}
else if (age > 64 && age <= 122)
{
    if (typeOfDay == "Weekday")
    {
        Console.WriteLine("12$");
    }
    else if (typeOfDay == "Weekend")
    {
        Console.WriteLine("15$");
    }
    else
    {
        Console.WriteLine("10$");
    }
}
else
{
    Console.WriteLine("Error!");
}