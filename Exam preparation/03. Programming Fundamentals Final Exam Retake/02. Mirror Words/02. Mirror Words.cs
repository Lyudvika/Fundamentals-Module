using System.Linq;
using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();

string pattern = @"(\@|\#)(?<firstName>[A-Za-z]{3,})\1{2}(?<secondName>[A-Za-z]{3,})\1";
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(inputLine);
List<string> result = new List<string>();

foreach (Match item in matches)
{
    string firstName = item.Groups["firstName"].Value;
    string secondName = item.Groups["secondName"].Value;
    string reversedName = string.Empty;

    for (int i = secondName.Length - 1; i >= 0; i--)
    {
        reversedName += secondName[i];
    }

    if (firstName == reversedName)
    {
        string combines = firstName + " <=> " + secondName;
        result.Add(combines);
    }
}

if (matches.Count <= 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}

if (result.Count <= 0)
{
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", result));
}