string text = Console.ReadLine();

Console.Write(text[0]);

for (int i = 1; i < text.Length; i++)
{
    if (text[i - 1] == text[i])
    {
        continue;
    }
    Console.Write(text[i]);
}