int number = int.Parse(Console.ReadLine());
number = number % 10;
string nameOfNumber = "";

switch (number)
{
    case 0:
        nameOfNumber = "zero";
        break;
    case 1:
        nameOfNumber = "one";
        break;
    case 2:
        nameOfNumber = "two";
        break;
    case 3:
        nameOfNumber= "three";
        break;
    case 4:
        nameOfNumber = "four";
        break;
    case 5:
        nameOfNumber = "five";
        break;
    case 6:
        nameOfNumber = "six";
        break;
    case 7:
        nameOfNumber = "seven";
        break;
    case 8:
        nameOfNumber = "eight";
        break;
    case 9:
        nameOfNumber = "nine";
        break;
}

Console.WriteLine(nameOfNumber);