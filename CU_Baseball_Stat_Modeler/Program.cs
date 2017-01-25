using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    class Program
    {


        static void Main(string[] args)
        {
            using(var db = new BaseballStatContext())
            {
                Console.WriteLine("Would you Like to Create a (T)eam, a (P)layer, or a (S)tat Sheet");
                var objectChoice = Console.ReadLine();
                    if (objectChoice = T)
                {
                    Console.WriteLine("What is the School Name of your team?");
                    var teamName = Console.ReadLine();
                    Console.WriteLine("What is the Mascot of your Team?");
                    var teamMascot = Console.ReadLine();
                    Console.WriteLine("Do you know the Rank of your time y/n");
                    var teamRankYN = Console.ReadLine();
                    if(teamRankYN = Y)
                    {
                        Console.WriteLine("What is the Rank of your Team");
                        var teamRankString = Console.ReadLine();
                         var teamRankInt = teamRankString.;
                    }
                    {

                    }
                }

            }
        }
    }
}
