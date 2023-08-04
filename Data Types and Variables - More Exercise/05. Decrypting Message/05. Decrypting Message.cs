int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int character = char.Parse(Console.ReadLine()) + key;

    Console.Write($"{(char)character}");
}