using System.Diagnostics.CodeAnalysis;
using System.Text;

int n = int.Parse(Console.ReadLine());
int[] sumOfAll = new int[n];

for (int i = 0; i < n; i++)
{
    string[] name = Console.ReadLine()
        .Split("")
        .ToArray();
    int sum = 0;

    for (int k = 0; k < name.Length; k++)
    {
        if (name[k] == "a" && name[k] == "e" && name[k] == "o" && name[k] == "i" && name[k] == "u" && 
            name[k] == "A" && name[k] == "E" && name[k] == "O" && name[k] == "I" && name[k] == "U")
        {
            sum += (Encoding.ASCII.GetByteCount(name[k]) * name.Length);
        }
        else
        {
            sum += (Encoding.ASCII.GetByteCount(name[k]) / name.Length);
        }
    }
    sumOfAll[i] = sum;
}
Array.Sort(sumOfAll);

for (int j = 0; j < sumOfAll.Length; j++)
{
    Console.WriteLine(sumOfAll[j]);
}