List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] tokens = input.Split(" ");
    string comman = tokens[0];
    int firstNumber = int.Parse(tokens[1]);

    if (comman == "Add")
    {
        numbers.Add(firstNumber);
    }
    else if (comman == "Remove")
    {
        numbers.Remove(firstNumber);
    }
    else if (comman == "RemoveAt")
    {
        numbers.RemoveAt(firstNumber);
    }
    else if (comman == "Insert")
    {
        int index = int.Parse(tokens[2]);
        numbers.Insert(index, firstNumber);
    }
}
Console.WriteLine(string.Join(" ", numbers));