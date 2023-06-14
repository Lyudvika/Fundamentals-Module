string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    int index = text.IndexOf(word);
    int length = word.Length;
    //text = text.Replace(word, "*");

    string replacement = new string('*', length);
    text = text.Replace(word, replacement);
}

Console.WriteLine(text);