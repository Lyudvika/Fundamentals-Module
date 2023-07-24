List<string> SeqOfElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

int numOfMoves = 0;
string input;
string numberToBeRemoved;

while ((input = Console.ReadLine()) != "end")
{
    string[] index = input.Split();
    int firstIndex = int.Parse(index[0]);
    int secondIndex = int.Parse(index[1]);

    numOfMoves++;

    if (firstIndex < 0 || firstIndex >= SeqOfElements.Count || secondIndex < 0 || secondIndex >= SeqOfElements.Count || firstIndex == secondIndex)
    {
        SeqOfElements.Insert(SeqOfElements.Count/2, "-" + numOfMoves + "a");
        SeqOfElements.Insert(SeqOfElements.Count / 2, "-" + numOfMoves + "a");
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        continue;
    }

    if (SeqOfElements[firstIndex] == SeqOfElements[secondIndex])
    {
        numberToBeRemoved = SeqOfElements[firstIndex];
        Console.WriteLine($"Congrats! You have found matching elements - {SeqOfElements[firstIndex]}!");
        SeqOfElements.Remove(numberToBeRemoved);
        SeqOfElements.Remove(numberToBeRemoved);
    }
    else
    {
        Console.WriteLine("Try again!");
    }

    if (SeqOfElements.Count == 0)
    {
        Console.WriteLine($"You have won in {numOfMoves} turns!");
        break;
    }
}

if (SeqOfElements.Count != 0)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", SeqOfElements));
}