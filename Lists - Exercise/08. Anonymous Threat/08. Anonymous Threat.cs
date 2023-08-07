List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
string command;

while ((command = Console.ReadLine()) != "3:1")
{
    string[] cmdArgs = command.Split();
    string cmdType = cmdArgs[0];

    if (cmdType == "merge")
    {
        int startIndex = int.Parse(cmdArgs[1]);
        int endIndex = int.Parse(cmdArgs[2]);

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (startIndex >= words.Count)
        {
            startIndex = words.Count - 1;
        }
        if (endIndex < 0)
        {
            endIndex = 0;
        }
        if (endIndex >= words.Count)
        {
            endIndex = words.Count - 1;
        }

        string mergedText = string.Empty;
        for (int i = startIndex; i <= endIndex; i++)
        {
            string currWord = words[startIndex];
            mergedText += currWord;
            words.RemoveAt(startIndex);
        }
        words.Insert(startIndex, mergedText);
    }
    else if (cmdType == "divide")
    {
        int index = int.Parse(cmdArgs[1]);
        int partitions = int.Parse(cmdArgs[2]);
        List<string> wordToBeDevided = new List<string>() { words[index] };
        int smallerParts = wordToBeDevided.Count / partitions;
        int num = smallerParts;

        for (int i = 0; i < partitions - 1; i++)
        {
            wordToBeDevided.Insert(smallerParts, " ");
            smallerParts += num + 1;

        }


        words.RemoveAt(index);
        words.Insert(index, );
    }
}

Console.WriteLine(string.Join(" ", words));