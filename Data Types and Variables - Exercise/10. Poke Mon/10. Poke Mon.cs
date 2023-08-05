int n = int.Parse(Console.ReadLine());      //energy i have
int m = int.Parse(Console.ReadLine());      //enery i need for a poke
byte y = byte.Parse(Console.ReadLine());    //devide

int targetsPocked = 0;
double halfOfN = n / 2.0;

while (n >= m)
{
    n -= m;
    targetsPocked++;

    if (n == halfOfN && y!=0)
    {
        n /= y;
    }
}

Console.WriteLine(n);
Console.WriteLine(targetsPocked);