using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pugstra.Models;


namespace Pugstra.Battle
{
    public class Attack
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

            //base
            //critical
            //weakness/resistance
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

        public int Attack_CalculateBaseDamage(Moves Move, Monster Attacker, Monster Defender)
        {
            //throw new NotImplementedException();

            //((rand(1,base) + attacker attack) - defense

            Random rand = new Random();
            int AttackValue = 0;
            int AttackerStat = 0;
            int DefenderStat = 0;

            if(Move.AttackType == 0)
            {
                AttackerStat = Attacker.PhysAttack;
                DefenderStat = Defender.PhysDef;
            } else
            {
                AttackerStat = Attacker.MagAttack;
                DefenderStat = Defender.MagDef;
            }


            AttackValue = ((rand.Next(1, Move.BaseDmg) / Defender.Level) * AttackerStat) / DefenderStat;

            if(AttackValue <= 0)
            {
                AttackValue = 1;
            }

            return AttackValue;
        }

    }
}
