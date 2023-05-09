using BattleGame;

namespace UnitTest
{
    [TestClass]
    public class HeroGeneratorTests
    {
        [TestMethod]
        [DataRow(10)]
        [DataRow(100)]
        [DataRow(0)]
        public void Generate(int expectedAmount)
        {
            var heros = HeroGenerator.Generate(expectedAmount);
            Assert.AreEqual(expectedAmount, heros.Count);
        }
    }
}