using BattleGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class HeroTests
    {
        [TestMethod]
        public void BowmanTest()
        {
            var hero = new Bowman();
            Assert.AreNotEqual(0, hero.Id);
            Assert.AreEqual(100, hero.Health);
            Assert.AreEqual(100, hero.MaxHealt);
            Assert.IsTrue(hero.IsAlive);
        }

        [TestMethod]
        public void SwordsTest()
        {
            var hero = new Swordsman();
            Assert.AreNotEqual(0, hero.Id);
            Assert.AreEqual(120, hero.Health);
            Assert.AreEqual(120, hero.MaxHealt);
            Assert.IsTrue(hero.IsAlive);
        }

        [TestMethod]
        public void RiderTest()
        {
            var hero = new Rider();
            Assert.AreNotEqual(0, hero.Id);
            Assert.AreEqual(150, hero.Health);
            Assert.AreEqual(150, hero.MaxHealt);
            Assert.IsTrue(hero.IsAlive);
        }

    }
}
