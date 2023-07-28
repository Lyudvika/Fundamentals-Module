int[] input = Console.ReadLine() //2 10 3 > 2+10 10+3 > 12 13 > 12 + 13 > 25
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0;i < input.Length; i++)
{
    for (int k = 0; k < input.Length - 1 - i; k++)
    {
        input[k] = input[k] + input[k + 1];
    }
}
Console.WriteLine(input[0]);