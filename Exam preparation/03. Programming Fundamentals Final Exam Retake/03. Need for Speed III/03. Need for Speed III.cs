var cars = new Dictionary<string, List<int>>();
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    string[] information = Console.ReadLine().Split("|");
    string car = information[0];
    int mileage = int.Parse(information[1]);
    int fuel = int.Parse(information[2]);

    cars.Add(car, new List<int> { mileage, fuel });
}

string command;

while ((command = Console.ReadLine()) != "Stop")
{
    string[] cmdArg = command.Split(" : ");
    string cmdType = cmdArg[0];
    string car = cmdArg[1];

    if (cmdType == "Drive")
    {
        int distance = int.Parse(cmdArg[2]);
        int fuel = int.Parse(cmdArg[3]);

        if (cars[car][1] < fuel)
        {
            Console.WriteLine("Not enough fuel to make that ride");
            continue;
        }

        cars[car][0] += distance;
        cars[car][1] -= fuel;
        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

        if (cars[car][0] >= 100000)
        {
            cars.Remove(car);
            Console.WriteLine($"Time to sell the {car}!");
            continue;
        }
    }
    else if (cmdType == "Refuel")
    {
        int fuel = int.Parse(cmdArg[2]);

        if (cars[car][1] + fuel > 75)
        {
            Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");
            cars[car][1] = 75;
        }
        else
        {
            Console.WriteLine($"{car} refueled with {fuel} liters");
            cars[car][1] += fuel;
        }
    }
    else if (cmdType == "Revert")
    {
        int kilometers = int.Parse(cmdArg[2]);

        cars[car][0] -= kilometers;

        if (cars[car][0] < 10000)
        {
            cars[car][0] = 10000;
            continue;
        }

        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
    }
}

foreach (var item in cars)
{
    string carName = item.Key;
    List<int> info = item.Value;
    Console.WriteLine($"{carName} -> Mileage: {info[0]} kms, Fuel in the tank: {info[1]} lt.");
}