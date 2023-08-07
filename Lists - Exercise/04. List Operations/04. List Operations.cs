List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];

    if (cmdType == "Add")
    {
        int number = int.Parse(cmdArr[1]);
        numbers.Add(number);
    }
    else if (cmdType == "Insert")
    {
        int number = int.Parse(cmdArr[1]);
        int index = int.Parse(cmdArr[2]);

        if (index >= numbers.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
            continue;
        }

        numbers.Insert(index, number);
    }
    else if (cmdType == "Remove")
    {
        int index = int.Parse(cmdArr[1]);

        if (index >= numbers.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
            continue;
        }

        numbers.RemoveAt(index);
    }
    else if (cmdType == "Shift")
    {
        string side = cmdArr[1];
        int count = int.Parse(cmdArr[2]);

        if (side == "left")
        {
            for (int i = 1; i <= count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Add(firstNumber);
                numbers.RemoveAt(0);
            }
        }
        else
        {
            for (int i = 1; i <= count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNumber);
                numbers.RemoveAt(numbers.Count-1);
            }
        }
    }
}

Console.WriteLine(string.Join(" ", numbers));