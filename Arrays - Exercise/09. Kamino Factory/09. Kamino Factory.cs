using System;

int length = int.Parse(Console.ReadLine());
int[] DNA = new int[length];
string input;

int numberOfSample = 0;
int currentSeqLength = 1;
int longestSeqLength = 1;
int bestSample = 0;
int[] bestDNA = new int[length];
int bestSum = 0;
int bestStart = 0;
int currentStart = 0;

while ((input = Console.ReadLine()) != "Clone them!")
{
    DNA = input.Split('!').Select(int.Parse).ToArray();
    numberOfSample++;
    int currentSum = 0;

    for (int i = 0; i < DNA.Length; i++)
    {
        currentSum += DNA[i];
    }

    for (int i = 1; i < DNA.Length; i++)
    {
        if (DNA[i] == DNA[i - 1])
        {
            currentSeqLength++;

            if (currentSeqLength > longestSeqLength)
            {
                longestSeqLength = currentSeqLength;
                bestSample = numberOfSample;
                bestDNA = DNA;
                bestSum = currentSum;
                bestStart = i;
            }
            else if (currentSeqLength == longestSeqLength && bestStart > currentStart)
            {
                longestSeqLength = currentSeqLength;
                bestSample = numberOfSample;
                bestDNA = DNA;
                bestSum = currentSum;
            }
        }
        else
        {
            currentSeqLength = 1;
        }
    }
}

Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");

for (int i = 0; i < bestDNA.Length; i++)
{
    Console.Write(bestDNA[i] + " ");
}