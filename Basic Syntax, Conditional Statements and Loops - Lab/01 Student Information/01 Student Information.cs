string studentsName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double avarageGrade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {studentsName}, Age: {age}, Grade: {avarageGrade:f2}");