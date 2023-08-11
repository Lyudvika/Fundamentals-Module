internal class Program
{
    private static void Main(string[] args)
    {
        double baseNumber = double.Parse(Console.ReadLine());
        double powerNumber = double.Parse(Console.ReadLine());
        double result = RaiseToPower(baseNumber, powerNumber);

        Console.WriteLine(result);
    }

    static double RaiseToPower(double baseNumber, double powerNumber)
    {
        return Math.Pow(baseNumber, powerNumber);
    }
}