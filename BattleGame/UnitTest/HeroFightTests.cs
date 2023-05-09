using BattleGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class HeroFightTests
    {
        //[TestMethod]
        //public void BowmanAttackRider()
        //{
        //    //arrange
        //    var attacker = new Bowman();
        //    var defender = new Rider();
        //    //act
        //    attacker.Attack(defender);
        //    //assert
        //    //Nyilván ez így helytelen, de mivel ez csak egy teszt feladat nem akartam több energiát fektetni egyenlőre bele
        //    var probabillity = new Random().Next(100);
        //    if (probabillity <= 40)
        //    {
        //        Assert.IsFalse(defender.IsAlive);
        //    }
        //    else
        //    {
        //        Assert.IsTrue(defender.IsAlive);
        //    }            
        //}

        [TestMethod]
        public void BowmanAttackSwordsman()
        {
            //arrange
            var attacker = new Bowman();
            var defender = new Swordsman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }

        [TestMethod]
        public void BowmanAttackBowman()
        {
            //arrange
            var attacker = new Bowman();
            var defender = new Bowman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }

        [TestMethod]
        public void SwordsmanAttackRider()
        {
            //arrange
            var attacker = new Swordsman();
            var defender = new Rider();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsTrue(defender.IsAlive);
        }

        [TestMethod]
        public void SwordsmanAttackSwordsman()
        {
            //arrange
            var attacker = new Swordsman();
            var defender = new Swordsman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }

        [TestMethod]
        public void SwordsmanAttackBowman()
        {
            //arrange
            var attacker = new Swordsman();
            var defender = new Bowman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }

        [TestMethod]
        public void RiderAttackRider()
        {
            //arrange
            var attacker = new Rider();
            var defender = new Rider();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }

        [TestMethod]
        public void RiderAttackSwordsman()
        {
            //arrange
            var attacker = new Rider();
            var defender = new Swordsman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(attacker.IsAlive);
        }

        [TestMethod]
        public void RiderAttackBowman()
        {
            //arrange
            var attacker = new Rider();
            var defender = new Bowman();
            //act
            attacker.Attack(defender);
            //assert
            Assert.IsFalse(defender.IsAlive);
        }
    }
}
