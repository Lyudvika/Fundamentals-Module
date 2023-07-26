int lines = int.Parse(Console.ReadLine());

for (int i = 1; i <= lines; i++)
{
    string text = Console.ReadLine();

    int indexStartName = text.IndexOf('@') + 1;
    int indexEndName = text.IndexOf('|');
    int indexStartAge = text.IndexOf('#') + 1;
    int indexEndAge = text.IndexOf('*');

    string name = text.Substring(indexStartName, indexEndName - indexStartName);
    string age = text.Substring(indexStartAge, indexEndAge - indexStartAge);
    Console.WriteLine($"{name} is {age} years old.");
}