using System.Text;

int[] key = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string command;

while ((command = Console.ReadLine()) != "find")
{
    StringBuilder sb = new StringBuilder();
    int index = 0;

    for (int i = 0; i < command.Length; i++)
    {
        sb.Append((char)(command[i] - key[index++]));

        if (index == key.Length)
        {
            index = 0;
        }
    }

    string newText = sb.ToString();

    int startIndexOfType = newText.IndexOf('&') + 1;
    int endIndexOfType = newText.LastIndexOf('&');
    string type = newText.Substring(startIndexOfType, endIndexOfType - startIndexOfType);

    int startIndexOfCoordinates = newText.IndexOf('<') + 1;
    int endIndexOfCoordinates = newText.IndexOf('>');
    string coordinates = newText.Substring(startIndexOfCoordinates, endIndexOfCoordinates - startIndexOfCoordinates);

    Console.WriteLine($"Found {type} at {coordinates}");
}