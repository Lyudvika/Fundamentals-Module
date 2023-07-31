int[] lineOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] firstHalfReversed = new int[lineOfNumbers.Length / 4];
int[] secondHalfReversed = new int[lineOfNumbers.Length / 4];

for (int i = 0; i < firstHalfReversed.Length; i++)
{
    firstHalfReversed[i] = lineOfNumbers[i];
}
Array.Reverse(firstHalfReversed);

Array.Reverse(lineOfNumbers);
for (int i = 0; i < secondHalfReversed.Length; i++)
{
    secondHalfReversed[i] = lineOfNumbers[i];
}

int[] sum = new int[lineOfNumbers.Length / 2];
Array.Reverse(lineOfNumbers);
int j = 0;
for (int i = 0; i < sum.Length; i++)
{
    sum[i] = lineOfNumbers[i + (lineOfNumbers.Length / 4)];
}
for (int i = 0; i < sum.Length; i++)
{
    if (i < sum.Length / 2)
    {
        sum[i] += firstHalfReversed[i];
    }
    else
    {
        sum[i] += secondHalfReversed[j];
        j++;
    }
}

for (int i = 0; i < sum.Length; i++)
{
    Console.Write(sum[i] + " ");
}