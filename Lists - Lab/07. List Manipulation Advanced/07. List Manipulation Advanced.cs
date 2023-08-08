List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
bool changesMade = false;
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] tokens = input.Split(" ");
    string comman = tokens[0];

    if (comman == "Add")
    {
        int number = int.Parse(tokens[1]);
        numbers.Add(number);

        changesMade = true;
    }
    else if (comman == "Remove")
    {
        int number = int.Parse(tokens[1]);
        numbers.Remove(number);

        changesMade = true;
    }
    else if (comman == "RemoveAt")
    {
        int index = int.Parse(tokens[1]);
        numbers.RemoveAt(index);

        changesMade = true;
    }
    else if (comman == "Insert")
    {
        int number = int.Parse(tokens[1]);
        int index = int.Parse(tokens[2]);
        numbers.Insert(index, number);

        changesMade = true;
    }
    else if (comman == "Contains")
    {
        int number = int.Parse(tokens[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (comman == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
    }
    else if (comman == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
    }
    else if (comman == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (comman == "Filter")
    {
        string condition = tokens[1];
        int number = int.Parse(tokens[2]);

        if (condition == ">")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
        }
        else if (condition == "<")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
        }
        else if (condition == "<=")
        {
            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
        }
    }
}

if (changesMade)
{
    Console.WriteLine(string.Join(" ", numbers));
}