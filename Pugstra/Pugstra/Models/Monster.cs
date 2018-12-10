using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pugstra.Models
{
    public class Monster
    {
        #region Properties
        public int Type_1 { get; set; } //elemental type
        public int Type_2 { get; set; } //elemental type
        public int Affinity { get; set; } //magical, physical
        public int PhysAttack { get; set; }
        public int PhysDef { get; set; }
        public int MagAttack { get; set; }
        public int MagDef { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Level { get; set; }
        #endregion
    }
}
