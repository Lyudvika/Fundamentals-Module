using System.Text.RegularExpressions;

string regex = @"(?<day>\d{2})(-|.|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
string text = Console.ReadLine();

MatchCollection matches = Regex.Matches(text, regex);

foreach (Match item in matches)
{
    Console.Write($"Day: {item.Groups["day"].Value}, ");
    Console.Write($"Month: {item.Groups["month"].Value}, ");
    Console.Write($"Year: {item.Groups["year"].Value}");
    Console.WriteLine();
}