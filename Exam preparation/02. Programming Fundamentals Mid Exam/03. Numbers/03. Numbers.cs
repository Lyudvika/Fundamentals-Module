List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
nums.Sort();
nums.Reverse();
List<int> result = new List<int>();
bool isThereAGreaterNum = false;

double sum = 0;
foreach (int num in nums)
{
    sum += num;
}

double avarageSum = sum / nums.Count;

foreach (int num in nums)
{
    if (num > avarageSum)
    {
        result.Add(num);
        isThereAGreaterNum = true;
    }

    if (result.Count == 5)
    {
        break;
    }
}

if (isThereAGreaterNum)
{
    Console.WriteLine(string.Join(" ", result));
}
else
{
    Console.Write("No");
}