int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int fourthNumber = int.Parse(Console.ReadLine());

long sum = firstNumber + secondNumber;
sum /= thirdNumber;
sum *= fourthNumber;

Console.WriteLine(sum);