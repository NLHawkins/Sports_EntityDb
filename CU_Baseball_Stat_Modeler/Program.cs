using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    class Program
    {
        public static void ToTeam(string teamNamestring)
        {
            var team = new Team
            {
                SchoolName = teamNamestring
            };
        }

        static void Main(string[] args)
        {
            using(var db = new BaseballStatContext())
            {
                Console.WriteLine("Create a new Player");
                Console.WriteLine("What is the name of your Player?");
                var playerName = Console.ReadLine();
                Console.WriteLine("What School is your Player from?");
                var playerTeam = (Console.ReadLine());
                ToTeam(playerTeam);
                Console.WriteLine("What Number is the Player on your Team");
                var playerNumber = int.Parse(Console.ReadLine());

                var userPlayer = new Player
                {
                    Name = playerName,                  
                    Number = playerNumber
                };

                db.Players.Add(userPlayer);
                db.SaveChanges();

                /*var teamOpp = new bool();
                teamOpp = db.Teams.Any(playerTeam);
                var teamMatch = db.Teams.Find(teamName);
                if (teamMatch = teamName)
                {
                    var professorNames = (from p in context.Professors
                                          select p.Name).ToList();

                    foreach (var name in professorNames)
                    {
                        Console.WriteLine(name);

                    }

                Console.WriteLine("Would you Like to Create a (T)eam, a (P)layer, or a (S)tat Sheet");
                var objectChoice = Console.ReadLine();
                if(objectChoice.ToLower() == "t")
                {
                    CreateTeam();
                }
*/
            }
        }


       

   /*      private static void CreateTeam()
        {
                Console.WriteLine("What is the School Name of your team?");
                var teamName = Console.ReadLine();
                Console.WriteLine("What is the Mascot of your Team?");
                var teamMascot = Console.ReadLine();
                Console.WriteLine("Do you know the Rank of your time y/n");
                var teamRankYN = Console.ReadLine();
                var teamRankInt = new int();

                if (teamRankYN.ToLower() == "y")
                {
                    Console.WriteLine("What is the Rank of your Team");
                    var teamRankString = Console.ReadLine();
                    teamRankInt = int.Parse(teamRankString);
                }
                else
                {
                    Console.WriteLine("Ok no Problem");
                }
                var teamId = new int();
                for (int i = 2; i < 100; i++)
                {
                    teamId = i;
                }

                var userTeam = new Team
                {
                    SchoolName = teamName,
                    Mascot = teamMascot,
                    Id = teamId
                };

                if (teamRankYN == "y")
                {
                    userTeam.Rank = teamRankInt;
                }           
        }

        public static void CreatePlayer()
        {
            Console.WriteLine("Which team [team Id] is your Player a part of?");
            Console.WriteLine();
        }*/
    }
}
