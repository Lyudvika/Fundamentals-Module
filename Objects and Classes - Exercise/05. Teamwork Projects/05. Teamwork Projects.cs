namespace _05._Teamwork_Projects
{
    using System;
    internal class Program
    {
        public const string CreatorTeamSeparator = "-";
        public const string EndCommand = "end of assignment";
        public const string UserJoinTeamSeparator = "->";
        static void Main()
        {
            List<Team> teams = new List<Team>();                    //list of all the teams

            int numOfTeamsCreating = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTeamsCreating; i++)
            {
                string[] teamArgs = Console.ReadLine().Split(CreatorTeamSeparator, StringSplitOptions.RemoveEmptyEntries);
                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamExists(teams, teamName))                                                    //checking if the team exists
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator))                                       //checking if the user has created another team
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);                                     //creating a new team
                    teams.Add(newTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command;
            while ((command = Console.ReadLine()) != EndCommand)
            {
                string[] comandArgs = command.Split(UserJoinTeamSeparator, StringSplitOptions.RemoveEmptyEntries);
                string user = comandArgs[0];
                string teamName = comandArgs[1];

                if (!TeamExists(teams, teamName))                                                   //if the team doesnt exist
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))                                        //if the given user is already a member of another team
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams                                                          //if  all the info is valid for the user to join a team
                        .First(t => t.Name == teamName);
                    teamToJoin.AddMember(user);
                }
            }

            List<Team> validTeams = teams
                 .Where(t => t.Members.Count > 0)
                 .OrderByDescending(t => t.Members.Count)
                 .ThenBy(t => t.Name)
                 .ToList();

            foreach (var team in validTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            List<Team> disbandTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (Team disbanTeam in disbandTeams)
            {
                Console.WriteLine($"{disbanTeam.Name}");
            }
        }

        static bool TeamExists(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }

        static bool AlreadyCreatedATeam(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string user)
        {
            return teams.Any(t => t.Creator == user || t.Members.Contains(user));
        }
    }

    public class Team
    {
        //fields
        private readonly List<string> members;

        // constructors
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>();
        }
        //properties
        public string Name { get; set; }

        public string Creator { get; set; }

        //get only property
        public IReadOnlyCollection<string> Members
            => this.members;

        // methods
        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}