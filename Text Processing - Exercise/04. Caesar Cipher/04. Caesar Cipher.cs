string input = Console.ReadLine();
string encruptedString = string.Empty;

foreach (char currChar in input)
{
    int currPosition = currChar;
    currPosition += 3;
    encruptedString += (char)currPosition;
}
Console.WriteLine(encruptedString);