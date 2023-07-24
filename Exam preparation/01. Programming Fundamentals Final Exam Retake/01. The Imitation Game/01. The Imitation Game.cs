using System.Text;

string wordToBeDecoded = Console.ReadLine();
StringBuilder word = new StringBuilder(wordToBeDecoded);
string command;

while ((command = Console.ReadLine()) != "Decode")
{
    string[] cmdArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArg[0];

    if (cmdType == "Move")
    {
        wordToBeDecoded = word.ToString();
        int numberOfLetters = int.Parse(cmdArg[1]);
        string lettersToBeTaken = wordToBeDecoded.Substring(0, numberOfLetters);
        word.Append(lettersToBeTaken);
        word.Remove(0, numberOfLetters);
    }
    else if (cmdType == "Insert")
    {
        int index = int.Parse(cmdArg[1]);
        string value = cmdArg[2];
        word.Insert(index, value);  //might need index - 1 
    }
    else if (cmdType == "ChangeAll")
    {
        string substring = cmdArg[1];
        string replacement = cmdArg[2];

        word.Replace(substring, replacement);
    }
}

Console.WriteLine($"The decrypted message is: {word.ToString()}");