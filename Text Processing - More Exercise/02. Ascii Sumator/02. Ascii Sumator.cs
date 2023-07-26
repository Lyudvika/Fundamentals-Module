char startIndex = char.Parse(Console.ReadLine());
char endIndex = char.Parse(Console.ReadLine());
string checkText = Console.ReadLine();

int sum = 0;

foreach (char ch in checkText)
{
    if (ch > startIndex && ch < endIndex)
    {
        sum += ch;
    }
}

Console.WriteLine(sum);