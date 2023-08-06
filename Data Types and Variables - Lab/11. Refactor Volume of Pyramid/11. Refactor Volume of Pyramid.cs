double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

Console.Write($"Length: Width: Height: ");

double V = (length * width * height) / 3;

Console.WriteLine($"Pyramid Volume: {V:f2}");