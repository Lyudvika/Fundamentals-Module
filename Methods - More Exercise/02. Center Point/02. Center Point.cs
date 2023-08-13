internal class Program
{
    private static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        CloserToCenterPoint(x1, y1, x2, y2);
    }

    private static void CloserToCenterPoint(double x1, double y1, double x2, double y2)
    {
        double firstResult = Math.Max(Math.Abs(x1), Math.Abs(y1));
        double secondResult = Math.Max(Math.Abs(x2), Math.Abs(y2));


        if (firstResult <= secondResult)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}