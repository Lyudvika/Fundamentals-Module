int n = int.Parse(Console.ReadLine());
int[] inputArray = new int[n];

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    inputArray[i] = input;
}

for (int i = inputArray.Length - 1;i >= 0; i--)
{
    Console.Write(inputArray[i] + " ");
}