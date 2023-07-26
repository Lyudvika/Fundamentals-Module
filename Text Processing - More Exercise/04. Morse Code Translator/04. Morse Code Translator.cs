using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string answear = MorseCodeTranslating(text);
        Console.WriteLine(answear);
    }

    public static string MorseCodeTranslating(string[] text)
    {
        StringBuilder translatedText = new StringBuilder();

        foreach (string word in text)
        {
            if (word.Contains('|'))
            {
                word.Replace('|', ' ');
            }

            switch (word)
            {
                case ".-":
                    translatedText.Append("A");
                    break;
                case "-...":
                    translatedText.Append("B");
                    break;
                case "-.-.":
                    translatedText.Append("C");
                    break;
                case "-..":
                    translatedText.Append("D");
                    break;
                case ".":
                    translatedText.Append("E");
                    break;
                case "..-.":
                    translatedText.Append("F");
                    break;
                case "--.":
                    translatedText.Append("G");
                    break;
                case "....":
                    translatedText.Append("H");
                    break;
                case "..":
                    translatedText.Append("I");
                    break;
                case ".---":
                    translatedText.Append("J");
                    break;
                case "-.-":
                    translatedText.Append("K");
                    break;
                case ".-..":
                    translatedText.Append("L");
                    break;
                case "--":
                    translatedText.Append("M");
                    break;
                case "-.":
                    translatedText.Append("N");
                    break;
                case "---":
                    translatedText.Append("O");
                    break;
                case ".--.":
                    translatedText.Append("P");
                    break;
                case "--.-":
                    translatedText.Append("Q");
                    break;
                case ".-.":
                    translatedText.Append("R");
                    break;
                case "...":
                    translatedText.Append("S");
                    break;
                case "-":
                    translatedText.Append("T");
                    break;
                case "..-":
                    translatedText.Append("U");
                    break;
                case "...-":
                    translatedText.Append("V");
                    break;
                case ".--":
                    translatedText.Append("W");
                    break;
                case "-..-":
                    translatedText.Append("X");
                    break;
                case "-.--":
                    translatedText.Append("Y");
                    break;
                case "--..":
                    translatedText.Append("Z");
                    break;
                default:
                    translatedText.Append(' ');
                    break;
            }
        }

        return translatedText.ToString();
    }
}