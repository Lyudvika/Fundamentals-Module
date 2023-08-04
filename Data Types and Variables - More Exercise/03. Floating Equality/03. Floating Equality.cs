double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());

double difference = Math.Abs(numberB - numberA);

if (difference > 0.000001)
{
    Console.WriteLine("False");
}
else
{
    Console.WriteLine("True");
}