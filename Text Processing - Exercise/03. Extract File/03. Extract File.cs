string[] input = Console.ReadLine().Split("\\");
string file = input[input.Length - 1];
string[] splitLastWord = file.Split('.');
Console.WriteLine($"File name: {splitLastWord[0]}");
Console.WriteLine($"File extension: {splitLastWord[1]}");