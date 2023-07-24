decimal taxes = 0;
decimal priceWithoutTax = 0;
string input;
while ((input = Console.ReadLine()) != "null")
{
    if (input == "regular" || input == "special")
    {
        break;
    }

    decimal price = decimal.Parse(input);

    if (price < 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }

    taxes += price * 0.2m;
    priceWithoutTax += price;

}

decimal priceWithTax = taxes + priceWithoutTax;
if (input == "special")
{
    priceWithTax *= 0.9m;
}

if (priceWithTax <= 0)
{
    Console.WriteLine("Invalid order!");
}
else
{
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {priceWithoutTax:f2}$");
    Console.WriteLine($"Taxes: {taxes:f2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {priceWithTax:f2}$");
}