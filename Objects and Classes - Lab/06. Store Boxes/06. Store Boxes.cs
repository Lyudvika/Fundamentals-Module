internal class Program
{
    private static void Main(string[] args)
    {
        List<Box> boxes = new();

        string command;
        string endCommand = "end";
        while ((command = Console.ReadLine()) != endCommand)
        {
            string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int serialNumber = int.Parse(cmdArg[0]);
            string itemName = cmdArg[1];
            int itemQuantity = int.Parse(cmdArg[2]);
            decimal itemPirce = decimal.Parse(cmdArg[3]);

            Box box = new Box();

            box.SerialNumber = serialNumber;
            box.Item.Name = itemName;
            box.ItemQuantity = itemQuantity;
            box.PriceForABox = itemPirce;

            box.Item.Price = itemPirce * itemQuantity;

            boxes.Add(box);
        }

        foreach (Box box in boxes.OrderByDescending(p => p.Item.Price))
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.Item.Price:f2}");
        }
    }
}

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    public Box()
    {
        Item = new Item();
    }

    public int SerialNumber { get; set; }

    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox { get; set; }
}