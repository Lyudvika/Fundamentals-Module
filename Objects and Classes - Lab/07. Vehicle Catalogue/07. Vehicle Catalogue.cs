using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        string command;
        string endCommand = "end";
        while ((command = Console.ReadLine()) != endCommand)
        {
            string[] cmdArg = command.Split("/");
            string type = cmdArg[0];
            string brand = cmdArg[1];
            string model = cmdArg[2];
            int weightOrHorsePower = int.Parse(cmdArg[3]);

            if (type == "Car")
            {
                Car cars = new Car(brand, model, weightOrHorsePower);
                catalog.Cars.Add(cars);
            }
            else
            {
                Truck trucks = new Truck(brand, model, weightOrHorsePower);
                catalog.Trucks.Add(trucks);
            }
        }

        if (catalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");

            foreach (var car in catalog.Cars.OrderBy(b => b.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }
        if (catalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");

            foreach (var truck in catalog.Trucks.OrderBy(b => b.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}

public class Truck
{
    public Truck(string brand, string model, int weightOrHorsePower)
    {
        Brand = brand;
        Model = model;
        Weight = weightOrHorsePower;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }     //might be double
}

public class Car
{
    public Car(string brand, string model, int weightOrHorsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = weightOrHorsePower;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

public class Catalog
{
    public Catalog() 
    { 
        Trucks = new();
        Cars = new();
    }

    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }

    public Catalog(string type, string brand, string model, int weightOrHorsePower)
    {
        Console.WriteLine($"{type}:");
    }
}