List<string> words = new List<string>();
string command;

while ((command = Console.ReadLine()) != "end")
{
    words.Add(command);
}

foreach (string word in words)
{
    Console.Write(string.Join(" ",word) + " = ");
    Console.WriteLine(string.Join("", word.Reverse()));
}