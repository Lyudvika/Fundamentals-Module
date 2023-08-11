internal class Program
{
    private static void Main(string[] args)
    {
        string product = Console.ReadLine();
        decimal quantity = decimal.Parse(Console.ReadLine());
        PricingOfProduct(product, quantity);
    }

    static void PricingOfProduct(string product, decimal quantity)
    {
        if (product == "coffee")
        {
            Console.WriteLine($"{1.50m * quantity:f2}");
        }
        else if (product == "water")
        {
            Console.WriteLine($"{1.00m * quantity:f2}");
        }
        else if (product == "coke")
        {
            Console.WriteLine($"{1.40m * quantity:f2}");
        }
        else if (product == "snacks")
        {
            Console.WriteLine($"{2.00m * quantity:f2}");
        }
    }
}