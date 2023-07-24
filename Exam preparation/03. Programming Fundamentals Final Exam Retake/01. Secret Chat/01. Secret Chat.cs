string text = Console.ReadLine();

string command;
while ((command = Console.ReadLine()) != "Reveal")
{
    string[] cmdArg = command.Split(":|:");
    string cmdType = cmdArg[0];

    if (cmdType == "InsertSpace")
    {
        int index = int.Parse(cmdArg[1]);
        text = text.Insert(index, " ");

        Console.WriteLine(text);
    }
    else if (cmdType == "Reverse")
    {
        string substring = cmdArg[1];
        if (!text.Contains(substring))
        {
            Console.WriteLine("error");
            continue;
        }

        char[] reversingTheSubstring = substring.ToCharArray();
        Array.Reverse(reversingTheSubstring);
        string reversedSubstring = new string(reversingTheSubstring);
        text = text.Insert(text.Length, reversedSubstring);
        int startIndex = text.IndexOf(substring);
        text = text.Remove(startIndex, substring.Length);    //??

        Console.WriteLine(text);
    }
    else if (cmdType == "ChangeAll")
    {
        string substring = cmdArg[1];
        string replacement = cmdArg[2];

        text = text.Replace(substring, replacement);

        Console.WriteLine(text);
    }
}

Console.WriteLine($"You have a new text message: {text}");