int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int biggerThanRightSide = 1;

for (int i = 0; i < input.Length; i++)
{
    for (int k = 1 + i; k < input.Length; k++)
    {
        if (input[i] > input[k])
        {
            biggerThanRightSide++;

            if (biggerThanRightSide > input.Length - 1 - i)
            {
                Console.Write(input[i] + " ");
            }
        }
    }

    if (i == input.Length - 1)
    {
        Console.Write(input[i]);
    }

    biggerThanRightSide = 1;
}