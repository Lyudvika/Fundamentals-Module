int firstEmployeeStuPerHour = int.Parse(Console.ReadLine());
int secondEmployeeStuPerHour = int.Parse(Console.ReadLine());
int thirdEmployeeStuPerHour = int.Parse(Console.ReadLine());
int studentCount = int.Parse(Console.ReadLine());

int hours = 0;
int studentsAsweredPerHour = firstEmployeeStuPerHour + secondEmployeeStuPerHour + thirdEmployeeStuPerHour;

while (studentCount > 0)
{
    hours++;
    if (hours % 4 == 0)
    {
        continue;
    }

    studentCount -= studentsAsweredPerHour;
}

Console.WriteLine($"Time needed: {hours}h.");