using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Pugstra.Models;

namespace Pugstra_Tests.Battle
{
    [TestFixture]
    class Attack_UnitTests
    {
        private Monster Attacker;
        private Monster Defender;
        private Moves move;


        [SetUp]
        public void Setup()
        {
            Attacker = new Monster();
            Defender = new Monster();
            move = new Moves();
        }

        [Test]
        public void Attack_CalculateBaseDamage_Should_ReturnValueGreaterThanZero()
        {
            var SUT = new Pugstra.Battle.Attack();
            int value = 0;
            
            Attacker.PhysAttack = 255;
            Attacker.MagAttack = 10;

            Defender.MagDef = 10;
            Defender.PhysDef = 255;
            Defender.Level = 5;//100;

            move.BaseDmg = 150;
            move.AttackType = 1; //0-physical

            value = SUT.Attack_CalculateBaseDamage(move, Attacker, Defender);

            Assert.GreaterOrEqual(value, 1);
            TestContext.Write($"Damage Dealt: {value}");
        }

    }
}
