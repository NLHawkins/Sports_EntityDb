using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    public class Team
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string SchoolName { get; set; }
        public string Mascot { get; set; }
        public DateTime NextGame { get; set; }
    }
}
