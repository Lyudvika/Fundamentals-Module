int n = int.Parse(Console.ReadLine());
int tankCapacity = 255;
int pouredLitters = 0;

for (int i = 0; i < n; i++)
{
    int littersPoured = int.Parse(Console.ReadLine());

    if (littersPoured > tankCapacity)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        tankCapacity -= littersPoured;
        pouredLitters+= littersPoured;
    }
}
Console.WriteLine(pouredLitters);