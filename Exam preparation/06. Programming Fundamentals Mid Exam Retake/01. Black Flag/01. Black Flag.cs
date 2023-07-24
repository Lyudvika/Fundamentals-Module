int days = int.Parse(Console.ReadLine());
int dailyPlunder = int.Parse(Console.ReadLine());
double expectedPlunder = double.Parse(Console.ReadLine());

double gatheredPlunder = 0;

for (int i = 1; i <= days; i++)
{
    gatheredPlunder += dailyPlunder;

    if (i % 3 == 0)
    {
        gatheredPlunder += dailyPlunder * 0.5;
    }

    if (i % 5 == 0)
    {
        gatheredPlunder -= gatheredPlunder * 0.3;
    }
}

if (expectedPlunder <= gatheredPlunder)
{
    Console.WriteLine($"Ahoy! {gatheredPlunder:f2} plunder gained.");
}
else
{
    Console.WriteLine($"Collected only {gatheredPlunder / expectedPlunder*100:f2}% of the plunder.");
}