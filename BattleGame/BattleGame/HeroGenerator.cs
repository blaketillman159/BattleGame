using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public static class HeroGenerator
    {
        /// <summary>
        /// N mennyiségű random típusú hős generálása
        /// </summary>
        /// <param name="amount">Darabszám</param>
        /// <returns>Hősök listája</returns>
        public static List<Hero> Generate(int amount)
        {
            var generatedHeros = Enumerable.Range(0, amount).Select(x => NewHero() ).ToList();
            generatedHeros.ForEach(gh =>
            {
                gh.ToDetails();
            });
            return generatedHeros;
        }

        /// <summary>
        /// Random típusú hős létrehozása
        /// </summary>
        /// <returns>Hős</returns>
        private static Hero NewHero()
        {
            var heroes = new List<Hero>() {
                new Bowman(),
                new Swordsman(),
                new Rider()
            };

            return heroes.Pick();
        }
    }
}
