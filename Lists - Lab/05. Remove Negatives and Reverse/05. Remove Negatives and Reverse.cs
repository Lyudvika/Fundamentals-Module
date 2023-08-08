List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

numbers.RemoveAll(x => x < 0);

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    numbers.Reverse();
    Console.WriteLine(string.Join(" ", numbers));