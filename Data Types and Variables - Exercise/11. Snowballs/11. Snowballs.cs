using System.Numerics;

int snowBallNumber = int.Parse(Console.ReadLine());

BigInteger bestSnowballValue = 0;
double bestSnowballSnow = 0;
double bestSnowballTime = 0;
double bestSnowballQuality = 0;

for (int i = 0; i < snowBallNumber; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
    if (snowballValue > bestSnowballValue)
    {
        bestSnowballValue = snowballValue;
        bestSnowballQuality = snowballQuality;
        bestSnowballSnow = snowballSnow;
        bestSnowballTime = snowballTime;
    }
}

Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");