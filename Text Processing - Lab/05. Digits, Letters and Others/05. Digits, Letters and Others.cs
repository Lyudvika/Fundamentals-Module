string text = Console.ReadLine();
string nums = string.Empty;
string isLetter = string.Empty;
string isSymbol = string.Empty;

foreach (var ch in text)
{
    if (char.IsDigit(ch))
    {
        nums += ch;
    }
    else if (char.IsLetter(ch))
    {
        isLetter += ch;
    }
    else
    {
        isSymbol += ch;
    }
}

Console.WriteLine(nums);
Console.WriteLine(isLetter);
Console.WriteLine(isSymbol);