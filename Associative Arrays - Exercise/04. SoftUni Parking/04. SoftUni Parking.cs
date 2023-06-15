namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string cmdType = cmdArg[0];
                string username = cmdArg[1];

                if (cmdType == "register")
                {
                    string lcplate = cmdArg[2];
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {lcplate}");
                        continue;
                    }
                    parking.Add(username, lcplate);
                    Console.WriteLine($"{username} registered {lcplate} successfully");
                }
                else
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    parking.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}