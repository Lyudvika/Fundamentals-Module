List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
List<double> result = new List<double>();

for (int i = 0; i < numbers.Count / 2; i++)
{
    double currSum = numbers[i] + numbers[numbers.Count - 1 - i];
    result.Add(currSum);
}

if (numbers.Count % 2 != 0)
{
    result.Add(numbers[numbers.Count / 2]);
}

Console.WriteLine(string.Join(" ", result));