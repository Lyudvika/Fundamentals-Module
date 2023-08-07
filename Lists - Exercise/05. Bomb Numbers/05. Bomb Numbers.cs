List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int[] cmdArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int number = cmdArr[0];
int index = cmdArr[1];

int whereIndexIs = 0;

while (numbers.Contains(number))
{
    for (int i = 0;i < numbers.Count; i++)
    {
        if (numbers[i] == number)
        {
            whereIndexIs = i; 
            break;
        }
    }

    int start = whereIndexIs - index;
    int end = whereIndexIs + index;
    if (start < 0)
    {
        start = 0;
    }
    if (end >= numbers.Count)
    {
        end = numbers.Count - 1;
    }

    for (int i = start; i <= end;i++)
    {
        numbers.RemoveAt(start);
    }
}

int sum = 0;

foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine(sum);