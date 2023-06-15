namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(" : ");
                string courseName = cmdArg[0];
                string stuName = cmdArg[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(stuName);
            }

            foreach (var item in courses)
            {
                string courseName = item.Key;
                List<string> students = item.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var name in students)
                {
                    Console.WriteLine("-- " + name);
                }
            }
        }
    }
}