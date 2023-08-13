namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            string result = "";
            result = CheckingThenResultOfTheNumbers(numOne, numTwo, numThree, result);
            Console.WriteLine(result);
        }

        static string CheckingThenResultOfTheNumbers(int numOne, int numTwo, int numThree, string result)
        {
            if (numOne == 0 || numTwo == 0 || numThree == 0)
            {
                result = "zero";
                return result;
            }
            else if (numOne < 0 || numTwo < 0 || numThree < 0)
            {
                if (numOne * numTwo * numThree < 0)
                {
                    result = "negative";
                    return result;
                }
                result = "positive";
                return result;
            }
            else
            {
                result = "positive";
                return result;
            }
        }
    }
}