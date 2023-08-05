int startingYield = int.Parse(Console.ReadLine());

int days = 0;
int yieldLeft = 0;

while (startingYield >= 100)
{
    yieldLeft += startingYield - 26;
    startingYield -= 10;

    days++;
}


if (yieldLeft >= 26)
{
    yieldLeft -= 26;
}

Console.WriteLine(days);
Console.WriteLine(yieldLeft);