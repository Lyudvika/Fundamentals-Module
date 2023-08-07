List<int> pokemons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int sum = 0;

while (pokemons.Count > 0)
{
    int index = int.Parse(Console.ReadLine());
    int valueOfPokemon = 0;

    if (index < 0 )
    {
        valueOfPokemon = pokemons[0];
        pokemons.RemoveAt(0);
        pokemons.Insert(0, pokemons[pokemons.Count - 1]);
    }
    else if (index >= pokemons.Count)
    {
        valueOfPokemon = pokemons[pokemons.Count - 1];
        pokemons.RemoveAt(pokemons.Count - 1);
        pokemons.Add(pokemons[0]);
    }
    else
    {
        valueOfPokemon = pokemons[index];
        pokemons.RemoveAt(index);
    }
    sum += valueOfPokemon;

    for (int i = 0; i < pokemons.Count; i++)
    {
        if (pokemons[i] <= valueOfPokemon)
        {
            pokemons[i] += valueOfPokemon;
        }
        else
        {
            pokemons[i] -= valueOfPokemon;
        }
    }
}

Console.WriteLine(sum);