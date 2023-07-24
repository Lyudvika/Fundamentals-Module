using System.Text.RegularExpressions;

string inputLine = Console.ReadLine();

string digitPattern = @"\d";
Regex digitRegex = new Regex(digitPattern);
MatchCollection digits = digitRegex.Matches(inputLine);

string emojiPattern = @"(::|\*\*)(?<emoji>[A-Z]{1}[a-z]{2,})\1";
Regex emojiRegex = new Regex(emojiPattern);
MatchCollection emojis = emojiRegex.Matches(inputLine);

int coolThreshold = 1;

foreach (Match digit in digits)
{
    coolThreshold *= int.Parse(digit.Value);
}

Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

foreach (Match emoji in emojis)
{
    int currSum = 0;
    string currEmoji = emoji.Groups["emoji"].Value;
    for (int i = 0; i < currEmoji.Length; i++)
    {
        currSum += currEmoji[i];
    }

    if (currSum >= coolThreshold)
    {
        Console.WriteLine(emoji);
    }
}