float quantityFood = float.Parse(Console.ReadLine()) * 1000;
float quantityHay = float.Parse(Console.ReadLine()) * 1000;
float quantityCover = float.Parse(Console.ReadLine()) * 1000;
float weightOfGuinea = float.Parse(Console.ReadLine()) * 1000;

for (int i = 1; i <= 30; i++)
{
    quantityFood -= 300f;

    if (i % 2 == 0)
    {
        quantityHay -= (quantityFood * 0.05f);
    }

    if (i % 3 == 0)
    {
        quantityCover -= (weightOfGuinea / 3.0f);
    }
    
    if (quantityCover < 0 || quantityFood < 0 || quantityHay < 0)
    {
        Console.WriteLine("Merry must go to the pet store!");
        break;
    }
}

if (quantityFood >= 0 && quantityCover >= 0 && quantityHay >= 0)
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood/1000:f2}, Hay: {quantityHay/1000:f2}, Cover: {quantityCover / 1000:f2}.");
}