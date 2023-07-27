int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int rotations = int.Parse(Console.ReadLine());

int[] output = new int[input.Length];
int place;

for (int i = 0;i < input.Length; i++)
{
    place = i + rotations;

    while (place >= input.Length)
    {
        place -= input.Length;
    }
    output[i] = input[place];
}

for (int i = 0;i < output.Length; i++)
{
    Console.Write(output[i] + " ");
}