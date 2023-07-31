int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] lis;
int[] length = new int[sequence.Length];
int[] previous = new int[sequence.Length];
int maxLength = 0;
int lastIndex = -1;

for (int i = 0; i < sequence.Length; i++)
{
    length[i] = 1;
    previous[i] = -1;

    for (int j = 0; j < i; j++)
    {
        if (sequence[j] < sequence[i] && length[j] >= length[i])
        {
            length[i] = 1 + length[j];
            previous[i] = j;
        }
    }

    if (length[i] > maxLength)
    {
        maxLength = length[i];
        lastIndex = i;
    }
}

lis = new int[maxLength];

for (int i = 0; i < maxLength; i++)
{
    lis[i] = sequence[lastIndex];
    lastIndex = previous[lastIndex];
}

Array.Reverse(lis);
Console.WriteLine(string.Join(" ", lis));