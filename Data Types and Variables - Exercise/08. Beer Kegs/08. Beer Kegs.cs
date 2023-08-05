int n = int.Parse(Console.ReadLine());
double biggersKeg = 0;
string winner = null;

for (int i = 0; i < n; i++)
{
    string modul = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double sizeOfKeg = Math.PI * radius * radius * height;

    if (sizeOfKeg > biggersKeg)
    {
        biggersKeg = sizeOfKeg;
        winner = modul;
    }
}

Console.WriteLine(winner);