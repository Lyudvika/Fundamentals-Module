int students = int.Parse(Console.ReadLine());
int numOfLectures = int.Parse(Console.ReadLine());
int bonus = int.Parse(Console.ReadLine());

double maxBonus = double.MinValue;
int maxAttendance = 0;

if (students == 0 || numOfLectures == 0)
{
    Console.WriteLine($"Max Bonus: 0.");
    Console.WriteLine($"The student has attended 0 lectures.");
    return;
}

for (int i = 1; i <= students; i++)
{
    int studentsAttendance = int.Parse(Console.ReadLine());

    double totalBonus = (double)studentsAttendance / numOfLectures * (5 + bonus);

    if (totalBonus > maxBonus)
    {
        maxBonus = totalBonus;
        maxAttendance = studentsAttendance;
    }
}

Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
Console.WriteLine($"The student has attended {maxAttendance} lectures.");