int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int k = 0; k < n; k++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write((char)('a' + i));
            Console.Write((char)('a' + k));
            Console.WriteLine((char)('a' + j));
        }
    }
}