int theInteger = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

for (int i = times; i <= 100; i++)
{
    Console.WriteLine($"{theInteger} X {i} = {i * theInteger}");

    if (i >= 10)
    {
        break;
    }
}