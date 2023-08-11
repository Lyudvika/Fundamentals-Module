internal class Program
{
    private static void Main(string[] args)
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = 0;
        sum = GetMultipleOfEvenAndOdds(number, sum);
        Console.WriteLine(sum);
    }

    static int GetMultipleOfEvenAndOdds(int number, int sum)
    {
        int evenSum = 0;
        int oddSum = 0;
        while (number > 0)
        {
            int numberBeingChecked = number % 10;
            number /= 10;
            if (numberBeingChecked % 2 == 0)
            {
                evenSum = GetSumOfEvenDigits(numberBeingChecked, evenSum);
            }
            else
            {
                oddSum = GetSumOfOddDigits(numberBeingChecked, oddSum);
            }
        }
        sum = oddSum * evenSum;
        return sum;
    }

    static int GetSumOfEvenDigits(int numberBeingChecked, int evenSum)
    {
        evenSum += numberBeingChecked;
        return evenSum;
    }

    static int GetSumOfOddDigits(int numberBeingChecked, int oddSum)
    {
        oddSum += numberBeingChecked;
        return oddSum;
    }
}