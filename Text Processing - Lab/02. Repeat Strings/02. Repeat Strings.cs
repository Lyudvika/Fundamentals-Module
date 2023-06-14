using System.Numerics;
using System.Text;

string[] text = Console.ReadLine().Split().ToArray();
StringBuilder result = new StringBuilder();

foreach (string line in text)
{
    int length = line.Length;
    for (int i = 0; i < length; i++)
    {
        result.Append(line);
    }
}

Console.WriteLine(result.ToString());