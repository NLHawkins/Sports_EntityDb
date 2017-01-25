using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_Baseball_Stat_Modeler
{
    public class Stat
    {
        [Key]
        public int Number { get; set; }
        public double BA { get; set; }
        public int H { get; set; }
        public int AB { get; set; }
        public int HR { get; set; }
        public int SO { get; set; }
    }
}
