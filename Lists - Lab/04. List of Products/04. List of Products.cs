﻿int n = int.Parse(Console.ReadLine());
List<string> fruits = new List<string>();

for (int i = 0; i < n; i++)
{
    string fruit = Console.ReadLine();
    fruits.Add(fruit);
}

fruits.Sort();

for (int i = 0; i < fruits.Count; i++)
{
    Console.WriteLine($"{i + 1}.{fruits[i]}");
}