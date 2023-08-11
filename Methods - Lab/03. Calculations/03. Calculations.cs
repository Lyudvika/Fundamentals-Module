internal class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        switch (command)
        {
            case "add":
                Add(firstNumber, secondNumber);
                break;
            case "divide":
                Divide(firstNumber, secondNumber);
                break;
            case "multiply":
                Multiply(firstNumber, secondNumber);
                break;
            case "subtract":
                Subtract(firstNumber, secondNumber);
                break;
        }
    }

    private static void Divide(double firstNumber, double secondNumber)
    {
        Console.WriteLine(firstNumber / secondNumber);
    }
    private static void Add(double firstNumber, double secondNumber)
    {
        Console.WriteLine(firstNumber + secondNumber);
    }
    private static void Multiply(double firstNumber, double secondNumber)
    {
        Console.WriteLine(firstNumber * secondNumber);
    }
    private static void Subtract(double firstNumber, double secondNumber)
    {
        Console.WriteLine(firstNumber - secondNumber);
    }
}