namespace _04._Students
{
    public class Program
    {
        public const string Separator = " ";
        static void Main(string[] args)
        {
            List<Student> strindents = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(Separator, StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                strindents.Add(student);
            }

            foreach (var student in strindents.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}