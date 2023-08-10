using System;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger sum = 1;

        for (int k = 2; k <= n; k++)
        {
            sum *= k;
        }

        Console.WriteLine(sum);
    }
}