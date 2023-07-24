using System.Text.RegularExpressions;

string pattern = @"(\@{1}\#+)(?<name>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})(\@{1}\#+)";
Regex regex = new Regex(pattern);

int n = int.Parse(Console.ReadLine());

for (int i = 0;  i < n; i++)
{
    string inputLine = Console.ReadLine();
    string numbersForCode = string.Empty;

    Match macth =  regex.Match(inputLine);
    if (!macth.Success)
    {
        Console.WriteLine("Invalid barcode");
        continue;
    }

    foreach (char item in inputLine)
    {
        if (char.IsDigit(item))
        {
            numbersForCode += item.ToString();
        }
    }

    if (numbersForCode.Length == 0)
    {
        Console.WriteLine("Product group: 00");
        continue;
    }

    Console.WriteLine($"Product group: {numbersForCode}");
}