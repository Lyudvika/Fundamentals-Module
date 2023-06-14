string remove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(remove))
{
    int num = text.IndexOf(remove);
    int length = remove.Length;
    text = text.Remove(num, length);
}

Console.WriteLine(text);