namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studentList = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string nameOfStudent = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentList.ContainsKey(nameOfStudent))
                {
                    studentList.Add(nameOfStudent, new List<double>());
                }
                studentList[nameOfStudent].Add(grade);
            }

            foreach (var student in studentList)
            {
                string name = student.Key;
                List<double> grades = student.Value;
                double avarageGrade = grades.Sum() / grades.Count;

                if (avarageGrade >= 4.50)
                {
                    Console.WriteLine($"{name} -> {avarageGrade:f2}");
                }
            }
        }
    }
}