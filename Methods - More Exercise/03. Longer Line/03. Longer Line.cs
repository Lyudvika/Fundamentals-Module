internal class Program
{
    private static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());
        CloserToCenterPoint(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    private static void CloserToCenterPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstResult = Math.Max(Math.Abs(x1), Math.Abs(y1));
        double secondResult = Math.Max(Math.Abs(x2), Math.Abs(y2));
        double thirdResult = Math.Max(Math.Abs(x3), Math.Abs(y3));
        double fourthResult = Math.Max(Math.Abs(x4), Math.Abs(y4));

        double sumOfFirstTwo = firstResult + secondResult;
        double sumOfSecondTwo = thirdResult + fourthResult;

        if (sumOfFirstTwo > sumOfSecondTwo)
        {
            if (firstResult <= secondResult)
            {
                Console.Write($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})({x1}, {y1})");
            }
        }
        else
        {
            if (thirdResult <= fourthResult)
            {
                Console.Write($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                Console.Write($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }
}