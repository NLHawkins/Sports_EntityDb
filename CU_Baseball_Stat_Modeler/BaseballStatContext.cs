using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    public class BaseballStatContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
