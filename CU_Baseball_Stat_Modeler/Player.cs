using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    public class Player
    {
        public string Name { get; set; }
        [Key]
        public int Number { get; set; }
        public Team Team { get; set; }
        public  Stat Stats { get; set; }
    }
}
