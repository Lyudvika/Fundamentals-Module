List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArg = input.Split();

    if (cmdArg.Length == 2)
    {
        int element = int.Parse(cmdArg[1]);

        numbers.RemoveAll(x => x == element);
    }
    else if (cmdArg.Length == 3)
    {
        int element = int.Parse(cmdArg[1]);
        int position = int.Parse(cmdArg[2]);

        numbers.Insert(position, element);
    }
}
Console.WriteLine(string.Join(" ", numbers));