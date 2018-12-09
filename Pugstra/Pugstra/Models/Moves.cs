using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pugstra.Models
{
    class Moves
    {
        private int IDNum { get; set; }
        private int BaseDmg { get; set; }
        private int CritChance { get; set; }
        private int MissChance { get; set; }
        private int ElementType { get; set; }
        private int AttackType { get; set; } //physical/magical
    }
}
