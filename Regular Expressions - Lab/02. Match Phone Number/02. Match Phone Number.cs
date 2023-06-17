using System.Text.RegularExpressions;

string regex = @"\+\b359( |-)\b2\1\d{3}\1\d{4}\b";
string text = Console.ReadLine();

MatchCollection matched = Regex.Matches(text, regex);

var matchedPhones = matched.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

Console.WriteLine(string.Join(", ", matched));