using System.Diagnostics;
using System.Text.RegularExpressions;

string patter = @"([=|\/])(?<itemName>[A-Z]{1}[A-Za-z]{2,})(\1)";
string inputLine = Console.ReadLine();

Regex regex = new Regex(patter);
MatchCollection matches = regex.Matches(inputLine);
List<string> names = new List<string>();

int sum = 0;

foreach (Match match in matches)
{
    string item = match.Groups["itemName"].Value;
    names.Add(item);
    sum += item.Length;
}

Console.WriteLine($"Destinations: {string.Join(", ", names)}");
Console.WriteLine($"Travel Points: {sum}");