internal class Program
{
    private static void Main(string[] args)
    {
        var pianist = new Dictionary<string, List<string>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] pieces = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            string piece = pieces[0];
            string composer = pieces[1];
            string key = pieces[2];

            if (!pianist.ContainsKey(piece))
            {
                pianist.Add(piece, new List<string>());
            }

            pianist[piece].Add(composer);
            pianist[piece].Add(key);
        }

        string command;

        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] cmdArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArg[0];
            string piece = cmdArg[1];

            if (cmdType == "Add")
            {
                string composer = cmdArg[2];
                string key = cmdArg[3];

                if (pianist.ContainsKey(piece))
                {
                    Console.WriteLine($"{piece} is already in the collection!");
                }
                else
                {
                    pianist.Add(piece, new List<string>());
                    pianist[piece].Add(composer);
                    pianist[piece].Add(key);
                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
            }
            else if (cmdType == "Remove")
            {
                if (pianist.ContainsKey(piece))
                {
                    pianist.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
            else if (cmdType == "ChangeKey")
            {
                string newKey = cmdArg[2];
                if (pianist.ContainsKey(piece))
                {
                    pianist[piece].RemoveAt(1);
                    pianist[piece].Add(newKey);
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }
        }

        foreach (var item in  pianist)
        {
            string piece = item.Key;
            List<string> pieces = item.Value;
            Console.WriteLine($"{piece} -> Composer: {pieces[0]}, Key: {pieces[1]}");
        }
    }
}