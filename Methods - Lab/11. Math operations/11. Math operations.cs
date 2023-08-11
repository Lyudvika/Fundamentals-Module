internal class Program
{
    private static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        char operators = char.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        Calculate(firstNumber, secondNumber, operators);
    }
    private static void Calculate(double firstNumber, double secondNumber, char operators)
    {
        switch (operators)
        {
            case '/':
                Console.WriteLine(firstNumber / secondNumber);
                break;
            case '*':
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case '+':
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case '-':
                Console.WriteLine(firstNumber - secondNumber);
                break;
        }
    }
}