decimal savings = decimal.Parse(Console.ReadLine());
List<int> drumset = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
List<int> drumsetUsed = new List<int>(drumset);
string input;

while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int hitPower = int.Parse(input);
    for (int i = 0; i < drumsetUsed.Count; i++)
    {
        drumsetUsed[i] -= hitPower;

        if (drumsetUsed[i] <= 0)
        {
            decimal checkingThePrice = drumset[i] * 3;
            if (savings >= checkingThePrice)
            {
                drumsetUsed[i] = drumset[i];
                savings -= checkingThePrice;
            }
            else
            {
                drumsetUsed.RemoveAt(i);
                drumset.RemoveAt(i);
                i--;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", drumsetUsed));
Console.WriteLine($"Gabsy has {savings:f2}lv.");