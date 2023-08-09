List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

double leftSum = 0;
double rightSum = 0;

for (int i = 0; i < number.Count / 2; i++)
{
    leftSum += number[i];

    if (number[i] == 0)
    {
        leftSum *= 0.8;
        continue;
    }
}

for (int i = number.Count - 1; i > number.Count / 2; i--)
{
    rightSum += number[i];

    if (number[i] == 0)
    {
        rightSum *= 0.8;
    }
}


if (leftSum < rightSum)
{
    Console.WriteLine($"The winner is left with total time: {leftSum}");
}
else if (rightSum < leftSum)
{
    Console.WriteLine($"The winner is right with total time: {rightSum}");
}