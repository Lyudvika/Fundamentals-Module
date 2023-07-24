List<string> inventory = Console.ReadLine().Split(", ").ToList();
string input;

while ((input = Console.ReadLine()) != "Craft!")
{
    string[] cmdArr = input.Split(" - ");
    string cmdType = cmdArr[0];
    bool doesTheItemExist = false;

    if (cmdType == "Collect")
    {
        string item = cmdArr[1];

        foreach (string items in inventory)
        {
            if (items == item)
            {
                doesTheItemExist = true;
                break;
            }
        }

        if (!doesTheItemExist)
        {
            inventory.Add(item);
        }
    }
    else if (cmdType == "Drop")
    {
        string item = cmdArr[1];

        foreach (string items in inventory)
        {
            if (items == item)
            {
                doesTheItemExist = true;
                break;
            }
        }

        if (doesTheItemExist)
        {
            inventory.Remove(item);
        }
    }
    else if (cmdType == "Renew")
    {
        string item = cmdArr[1];

        foreach (string items in inventory)
        {
            if (items == item)
            {
                doesTheItemExist = true;
                break;
            }
        }

        if (doesTheItemExist)
        {
            inventory.Remove(item);
            inventory.Add(item);
        }
    }
    else
    {
        string[] oldNew = cmdArr[1].Split(":");
        string oldItem = oldNew[0];
        string newItem = oldNew[1];
        int placement = 0;

        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i] == oldItem)
            {
                placement = i;
                doesTheItemExist = true;
                break;
            }
        }

        if (doesTheItemExist)
        {
            inventory.Insert(placement + 1, newItem);
        }
    }
}

Console.WriteLine(string.Join(", ", inventory));