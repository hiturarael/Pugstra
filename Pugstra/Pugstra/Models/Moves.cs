using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pugstra.Models
{
    public class Moves
    {
        public int IDNum { get; set; }
        public int BaseDmg { get; set; }
        public int CritChance { get; set; }
        public int MissChance { get; set; }
        public int ElementType { get; set; }
        public int AttackType { get; set; } //physical/magical
    }
}
