using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pugstra.Models
{
    class Monster
    {
        #region Properties
        private int Type_1 { get; set; } //elemental type
        private int Type_2 { get; set; } //elemental type
        private int Affinity { get; set; } //magical, physical
        private int PhysAttack { get; set; }
        private int PhysDef { get; set; }
        private int MagAttack { get; set; }
        private int MagDef { get; set; }
        private int Speed { get; set; }
        private int Luck { get; set; }
        private int MaxHP { get; set; }
        private int CurrentHP { get; set; }
        #endregion
    }
}
