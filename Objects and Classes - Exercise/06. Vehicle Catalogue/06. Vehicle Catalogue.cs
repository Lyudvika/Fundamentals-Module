using System.Text;

namespace _06._Vehicle_Catalogue
{
    public class Program
    {
        public const string EndCommand = "End";
        public const string Separator = " ";
        public const string CloseCatalogueCommand = "Close the Catalogue";
        static void Main(string[] args)
        {
            List<VehicleCatalogue> catalogue = new();

            string command;
            while ((command = Console.ReadLine()) != EndCommand)
            {
                string[] infoArray = command.Split(Separator, StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = infoArray[0];
                typeOfVehicle = char.ToUpper(typeOfVehicle[0]) + typeOfVehicle.Substring(1, typeOfVehicle.Length - 1);

                string model = infoArray[1];
                string color = infoArray[2];
                double horsepower = double.Parse(infoArray[3]);

                VehicleCatalogue vehicle = new VehicleCatalogue(typeOfVehicle, model, color, horsepower);
                catalogue.Add(vehicle);
            }

            while ((command = Console.ReadLine()) != CloseCatalogueCommand)
            {
                Console.WriteLine(string.Join("", catalogue.Where(m => m.Model == command)));
            }

            if (catalogue.Any(c => c.TypeOfVehicle == "Car"))
            {

                Console.WriteLine($"Cars have average horsepower of: {catalogue.Where(c => c.TypeOfVehicle == "Car").Sum(h => h.Horsepower) / catalogue.Where(c => c.TypeOfVehicle == "Car").Count():f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }


            if (catalogue.Any(c => c.TypeOfVehicle == "Truck"))
            {

                Console.WriteLine($"Trucks have average horsepower of: {catalogue.Where(c => c.TypeOfVehicle == "Truck").Sum(h => h.Horsepower) / catalogue.Where(c => c.TypeOfVehicle == "Truck").Count():f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }

    public class VehicleCatalogue
    {
        public VehicleCatalogue(string typeOfVehicle, string model, string color, double horsepower) 
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {TypeOfVehicle}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.Append($"Horsepower: {Horsepower}");

            return sb.ToString();
        }
    }
}