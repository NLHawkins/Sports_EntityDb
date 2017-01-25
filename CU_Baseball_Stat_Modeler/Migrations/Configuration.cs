namespace CU_Baseball_Stat_Modeler.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CU_Baseball_Stat_Modeler.BaseballStatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CU_Baseball_Stat_Modeler.BaseballStatContext context)
        {
            var clemson = new Team
            {
                Id = 1,
                Rank = 1,
                SchoolName = "Clemson University",
                Mascot = "Tigers",
                NextGame = DateTime.Now
            };

            var player1 = new Player
            {
                Name = "Seth Beer",
                Number = 28,
                Team = clemson,
            };

            var Stats1 = new Stat
            {
                Number = 28,
                BA = 0.369,
                H = 75,
                AB = 203,
                HR = 18,
            };

            context.Players.Add(player1);
            context.Teams.Add(clemson);
            context.Stats.Add(Stats1);
            context.SaveChanges();


        }
    }
}
