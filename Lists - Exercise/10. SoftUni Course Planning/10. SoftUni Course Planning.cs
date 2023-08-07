List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
string input;

while ((input = Console.ReadLine()) != "course start")
{
    string[] cmdArr = input.Split(":");
    string cmdType = cmdArr[0];
    string lessonTitle = cmdArr[1];

    if (cmdType == "Add")
    {
        if (!courses.Contains(lessonTitle))
        {
            courses.Add(lessonTitle);
        }
    }
    else if (cmdType == "Insert")
    {
        int index = int.Parse(cmdArr[2]);

        if (!courses.Contains(lessonTitle))
        {
            courses.Insert(index, lessonTitle);
        }
    }
    else if (cmdType == "Remove")
    {
        if (courses.Contains(lessonTitle))
        {
            courses.Remove(lessonTitle);
            if (courses.Contains(lessonTitle + "-Exercise"))
            {
                courses.Remove(lessonTitle + "-Exercise");
            }
        }
    }
    else if (cmdType == "Swap")
    {
        string lessonTitleTwo = cmdArr[2];

        if (courses.Contains(lessonTitleTwo) && courses.Contains(lessonTitle)) 
        {
            int first = courses.IndexOf(lessonTitleTwo);
            int second = courses.IndexOf(lessonTitle);

            courses.RemoveAt(first);
            courses.Insert(first, lessonTitle);
            courses.RemoveAt(second);
            courses.Insert(second, lessonTitleTwo);

            if (courses.Contains(lessonTitle + "-Exercise"))
            {
                courses.Remove(lessonTitle + "-Exercise");
                courses.Insert(first + 1, lessonTitle + "-Exercise");
            }
            else if (courses.Contains(lessonTitleTwo + "-Exercise"))
            {
                courses.Remove(lessonTitleTwo + "-Exercise");
                courses.Insert(second + 1, lessonTitleTwo + "-Exercise");
            }
        }
    }
    else if (cmdType == "Exercise")
    {
        if (!courses.Contains(lessonTitle))
        {
            courses.Add(lessonTitle);
            courses.Add(lessonTitle + "-Exercise");
        }
        else if (!courses.Contains(lessonTitle + "-Exercise"))
        {
            int index = courses.IndexOf(lessonTitle);
            courses.Insert(index + 1, lessonTitle + "-Exercise");
        }
    }
}

for (int i = 0; i < courses.Count;i++)
{
    Console.WriteLine($"{i + 1}.{courses[i]}");
}