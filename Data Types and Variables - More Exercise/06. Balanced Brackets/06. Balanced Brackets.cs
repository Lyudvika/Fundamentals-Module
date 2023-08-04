int n = int.Parse(Console.ReadLine());

int balance = 0;

for (int i = 1; i <= n; i++)
{
    string text = Console.ReadLine();
    if (text == "(")
    {
        balance++;
    }
    if (text == ")")
    {
        balance--;
    }
    if (balance >= 2 || balance <= -1)
    {
        break;
    }
}

if (balance == 0)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}