using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    public static class HeroPicker
    {
        /// <summary>
        /// Egy hős kiválasztása és kivétele a listából
        /// </summary>
        /// <param name="heroes">Hős lista</param>
        /// <returns>Választott hős</returns>
        public static Hero Pick(this List<Hero> heroes)
        {
            if (heroes.Count > 0)
            {
                var selectedi = new Random().Next(heroes.Count);
                var selectedHero = heroes[selectedi];
                heroes.Remove(selectedHero);
                return selectedHero;
            }
            return null;
        }
    }
}
