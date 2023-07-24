using System.Security.Cryptography;

string key = Console.ReadLine();
string command;

while ((command = Console.ReadLine()) != "Generate")
{
    string[] cmdArg = command.Split(">>>");
    string cmdTupe = cmdArg[0];

    if (cmdTupe == "Contains")
    {
        string substring = cmdArg[1];

        if (key.Contains(substring))
        {
            Console.WriteLine($"{key} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (cmdTupe == "Flip")
    {
        string lowerOrUpper = cmdArg[1];
        int startIndex = int.Parse(cmdArg[2]);
        int endIndex = int.Parse(cmdArg[3]);

        string substring = key.Substring(startIndex, endIndex - startIndex);

        if (lowerOrUpper == "Lower")
        {
            string toLower = substring.ToLower();
            key = key.Replace(substring, toLower);
        }
        else    //Upper
        {
            string toUpper = substring.ToUpper();
            key = key.Replace(substring, toUpper);
        }

        Console.WriteLine(key);
    }
    else if (cmdTupe == "Slice")
    {
        int startIndex = int.Parse(cmdArg[1]);
        int endIndex = int.Parse(cmdArg[2]);

        key = key.Remove(startIndex, endIndex - startIndex);
        Console.WriteLine(key);
    }
}

Console.WriteLine($"Your activation key is: {key}");