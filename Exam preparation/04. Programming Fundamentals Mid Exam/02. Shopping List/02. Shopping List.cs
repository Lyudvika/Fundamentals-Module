List<string> shoppingList = Console.ReadLine().Split("!").ToList();
string input;

while ((input = Console.ReadLine()) != "Go Shopping!")
{
    string[] cmdArr = input.Split();
    string cmdType = cmdArr[0];
    bool isItInTheList = false;

    if (cmdType == "Urgent")
    {
        string item = cmdArr[1];
     
        foreach (string items in shoppingList)
        {
            if (items == item)
            {
                isItInTheList = true;
                break;
            }
        }

        if (!isItInTheList)
        {
            shoppingList.Insert(0, item);
        }
    }
    else if (cmdType == "Unnecessary")
    {
        string item = cmdArr[1];

        foreach (string items in shoppingList)
        {
            if (items == item)
            {
                isItInTheList = true;
                break;
            }
        }

        if (isItInTheList)
        {
            shoppingList.Remove(item);
        }
    }
    else if (cmdType == "Correct")
    {
        string oldItem = cmdArr[1];
        string newItem = cmdArr[2];
        int index = 0;

        for (int i = 0; i < shoppingList.Count; i++)
        {
            if (shoppingList[i] == oldItem)
            {
                isItInTheList = true;
                index = i;
                break;
            }
        }

        if (isItInTheList)
        {
            shoppingList.Remove(oldItem);
            shoppingList.Insert(index, newItem);
        }
    }
    else
    {
        string item = cmdArr[1];

        foreach (string items in shoppingList)
        {
            if (items == item)
            {
                isItInTheList = true;
                break;
            }
        }

        if (isItInTheList)
        {
            shoppingList.Remove(item);
            shoppingList.Add(item);
        }
    }
}

Console.WriteLine(string.Join(", ", shoppingList));