int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];

    if (cmdArr.Length == 1)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]--;
        }
    }
    else if (cmdType == "swap")
    {
        int firstIndex = int.Parse(cmdArr[1]);
        int secondIndex = int.Parse(cmdArr[2]);
        int firstNumber = arr[firstIndex];

        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = firstNumber;
    }
    else if (cmdType == "multiply")
    {
        int firstIndex = int.Parse(cmdArr[1]);
        int secondIndex = int.Parse(cmdArr[2]);

        int multiply = arr[firstIndex] * arr[secondIndex];
        arr[firstIndex] = multiply;
    }
}

Console.WriteLine(string.Join(", ", arr));