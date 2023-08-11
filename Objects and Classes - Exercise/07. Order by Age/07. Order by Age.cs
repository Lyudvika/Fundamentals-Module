namespace _07._Order_by_Age
{
    public class Program
    {
        public const string EndCommand = "End";
        public const string Separator = " ";
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != EndCommand)
            {
                string[] personInfo = command.Split(Separator, StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                if (people.Any(i => i.Id == id))
                {
                    people.First(i => i.Id == id).Name = name;
                    people.First(i => i.Id == id).Age = age;
                    continue;
                }

                Person person = new Person(name, id, age);
                people.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(a => a.Age)));
        }
    }

    public class Person
    {
        public Person(string name, string id, int age) 
        { 
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void ChangeInfo(string name, string id, int age)
        {

        }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}