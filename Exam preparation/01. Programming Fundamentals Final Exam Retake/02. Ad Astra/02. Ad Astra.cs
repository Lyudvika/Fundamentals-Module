using System.Text.RegularExpressions;

string pattern = @"([\|\#])(?<itemName>[A-Za-z\s]+)(\1)(?<expDate>\d{2}/\d{2}/\d{2})(\1)(?<calories>\d{1,5})(\1)";
Regex regex = new Regex(pattern);
string inputLine = Console.ReadLine();

MatchCollection matchCollection = regex.Matches(inputLine);
int sumOfCalories = 0;

foreach (Match match in matchCollection)
{
    string macthCalorries = match.Groups["calories"].Value;
    sumOfCalories += int.Parse(macthCalorries)  ;
}

int daysToLast = sumOfCalories / 2000;
Console.WriteLine($"You have food to last you for: {daysToLast} days!");

foreach (Match match in matchCollection)
{
    Console.WriteLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["expDate"].Value}, Nutrition: {match.Groups["calories"].Value}");
}