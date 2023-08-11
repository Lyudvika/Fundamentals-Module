internal class Program
{
    private static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = GetRectagnleArea(width, height);
        Console.WriteLine(area);
    }

    static double GetRectagnleArea(double width, double height)
    {
        return width * height;
    }
}