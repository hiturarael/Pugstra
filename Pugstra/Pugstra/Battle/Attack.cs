using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pugstra.Models;


namespace Pugstra.Battle
{
    class Attack
    {
        public void Attack_Execute(Moves Move, Monster Attacker, Monster Defender)
        {
            //check if defender cancels out the attack via type

            //check if miss/hit

            //calculate damage

            //deal damage
        }

        public int Attack_CalculateDamage(Moves Move, Monster Attacker, Monster Defender)
        {
            throw new NotImplementedException();

            
        }

        public bool Attack_CancelledOut(Moves Move, Monster Defender)
        {
            throw new NotImplementedException();
        }

        public bool Attack_Lands(Moves Move, Monster Attacker, Monster Defender)
        {
            throw new NotImplementedException();
        }

        public bool Attack_DealDamage(int Damage, Monster Defender)
        {
            throw new NotImplementedException();
        }
    }
}
