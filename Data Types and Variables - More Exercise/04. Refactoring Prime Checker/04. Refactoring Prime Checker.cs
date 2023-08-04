int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    string prime = "true";

    for (int splitter = 2; splitter < i; splitter++)
    {
        if (i % splitter == 0)
        {
            prime = "false";
            break;
        }
    }

    Console.WriteLine("{0} -> {1}", i, prime);
}