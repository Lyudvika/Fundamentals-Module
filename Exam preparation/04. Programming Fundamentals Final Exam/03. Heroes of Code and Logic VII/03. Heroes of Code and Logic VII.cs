internal class Program
{
    private static void Main(string[] args)
    {
        var heroesInfo = new Dictionary<string, List<int>>();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 1; i <= lines; i++)
        {
            string[] informationg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string heroName = informationg[0];
            int hp = int.Parse(informationg[1]);
            int mp = int.Parse(informationg[2]);

            heroesInfo.Add(heroName, new List<int>() { hp, mp });
        }

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] cmdArg = command.Split(" - ");
            string cmdType = cmdArg[0];
            string heroName = cmdArg[1];

            if (cmdType == "CastSpell")
            {
                int mpNeeded = int.Parse(cmdArg[2]);
                string spellName = cmdArg[3];

                if (heroesInfo[heroName][1] >= mpNeeded)
                {
                    heroesInfo[heroName][1] -= mpNeeded;
                    Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesInfo[heroName][1]} MP!"); //might be an error
                }
                else
                {
                    Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                }
            }
            else if (cmdType == "TakeDamage")
            {
                int damage = int.Parse(cmdArg[2]);
                string attacker = cmdArg[3];

                heroesInfo[heroName][0] -= damage;
                int currHp = heroesInfo[heroName][0];

                if (heroesInfo[heroName][0] > 0)
                {
                    Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currHp} HP left!");
                }
                else
                {
                    heroesInfo.Remove(heroName);
                    Console.WriteLine($"{heroName} has been killed by {attacker}!");
                }
            }
            else if (cmdType == "Recharge")
            {
                int rechargeAmount = int.Parse(cmdArg[2]);
                int amountRecovered = rechargeAmount;

                if (heroesInfo[heroName][1] + rechargeAmount > 200)
                {
                    amountRecovered = 200 - heroesInfo[heroName][1];
                    heroesInfo[heroName][1] = 200;
                }
                else
                {
                    heroesInfo[heroName][1] += rechargeAmount;
                }

                Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
            }
            else if (cmdType == "Heal")
            {
                int amountToHeal = int.Parse(cmdArg[2]);
                int amountRecovered = amountToHeal;

                if (heroesInfo[heroName][0] + amountToHeal > 100)
                {
                    amountRecovered = 100 - heroesInfo[heroName][0];
                    heroesInfo[heroName][0] = 100;
                }
                else
                {
                    heroesInfo[heroName][0] += amountToHeal;
                }

                Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
            }
        }

        foreach (var item in heroesInfo)
        {
            string name = item.Key;
            List<int> states = item.Value;

            Console.WriteLine(name);
            Console.WriteLine("HP: " + states[0]);
            Console.WriteLine("MP: " + states[1]);
        }
    }
}