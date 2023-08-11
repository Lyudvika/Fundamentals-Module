using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string command = Console.ReadLine();
        string firstItem = Console.ReadLine();
        string secondItem = Console.ReadLine();

        switch (command)
        {
            case "int":
                ConvertFromInt(firstItem, secondItem);
                break;
            case "string":
                ConvertFromString(firstItem, secondItem);
                break;
            case "char":
                ConvertFromChar(firstItem, secondItem);
                break;
        }
    }

    private static void ConvertFromInt(string firstItem, string secondItem)
    {
        double firstNumber = double.Parse(firstItem);
        double secondNumber = double.Parse(secondItem);
        if (firstNumber >= secondNumber)
        {
            Console.WriteLine(firstItem);
        }
        else
        {
            Console.WriteLine(secondItem);
        }
    }

    private static void ConvertFromString(string firstItem, string secondItem)
    {
        int result = (firstItem).CompareTo(secondItem);
        if (result > 0)
        {
            Console.WriteLine(firstItem);
        }
        else
        {
            Console.WriteLine(secondItem);
        }
    }

    private static void ConvertFromChar(string firstItem, string secondItem)
    {
        char firstChar = char.Parse(firstItem);
        char secondChar = char.Parse(secondItem);

        if (firstChar > secondChar)
        {
            Console.WriteLine(firstItem);
        }
        else
        {
            Console.WriteLine(secondItem);
        }
    }
}