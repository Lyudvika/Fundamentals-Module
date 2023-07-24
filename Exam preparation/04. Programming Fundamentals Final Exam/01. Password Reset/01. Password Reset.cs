using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string password = Console.ReadLine();
        password = DoingOperationsOnThePassword(password);

        Console.WriteLine($"Your password is: {password}");
    }

    public static string DoingOperationsOnThePassword(string password)
    {
        string command;
        while ((command = Console.ReadLine()) != "Done")
        {
            string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArg[0];

            if (cmdType == "TakeOdd")
            {
                password = TakeOddLettersFromString(password);
            }
            else if (cmdType == "Cut")
            {
                password = CutAPartFromThePassword(password, cmdArg);
            }
            else if (cmdType == "Substitute")
            {
                password = SubstituteASubstring(password, cmdArg);
            }
        }

        return password;
    }

    public static string TakeOddLettersFromString (string password)
    {
        StringBuilder newPassword = new StringBuilder();

        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
                newPassword.Append(password[i]);
            }
        }

        Console.WriteLine(newPassword.ToString());
        return newPassword.ToString();
    }

    public static string CutAPartFromThePassword(string password, string[] cmdArg)
    {
        int index = int.Parse(cmdArg[1]);
        int length = int.Parse(cmdArg[2]);

        password = password.Remove(index, length); //string substringToBeRemoved = password.Substring(index, length);
        Console.WriteLine(password);
        return password;
    }

    public static string SubstituteASubstring(string password, string[] cmdArg)
    {
        string substring = cmdArg[1];
        string substitute = cmdArg[2];

        if (password.Contains(substring))
        {
            password = password.Replace(substring, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }

        return password;
    }
}