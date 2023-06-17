using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string text = Console.ReadLine();

MatchCollection matchCollection = Regex.Matches(text, pattern);

foreach (Match name in matchCollection)
{
    Console.Write(name.Value + " ");
}
Console.WriteLine();