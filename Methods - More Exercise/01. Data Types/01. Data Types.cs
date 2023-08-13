using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string givenInputToChange = Console.ReadLine();
            if (input == "int")
            {
                int result = ConvertingFromInt(givenInputToChange);
                Console.WriteLine(result);
            }
            else if (input == "real")
            {
                double result = ConvertingFromReal(givenInputToChange);
                Console.WriteLine($"{result:f2}");
            }
            else if (input == "string")
            {
                Console.WriteLine("$" + givenInputToChange + "$");
            }
        }

        static int ConvertingFromInt(string givenInputToChange)
        {
            int result = int.Parse(givenInputToChange);
            return result * 2;
        }

        static double ConvertingFromReal(string givenInputToChange)
        {
            double result = double.Parse(givenInputToChange);
            return result * 1.5;
        }
    }
}