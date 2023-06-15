namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var companyUsers = new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(" -> ");
                string companyName = cmdArg[0];
                string employeeId = cmdArg[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }

                if (!companyUsers[companyName].Contains(employeeId))
                {
                    companyUsers[companyName].Add(employeeId);
                }
            }

            foreach (var item in companyUsers)
            {
                string name = item.Key;
                List<string> id = item.Value;
                Console.WriteLine(name);
                foreach (var employee in id)
                {
                    Console.WriteLine("-- " + employee);
                }
            }
        }
    }
}