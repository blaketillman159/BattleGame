using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    /// <summary>
    /// Csata reprezentálása
    /// </summary>
    internal class Game
    {

        private List<Hero> players = null;
        public bool GameOver { 
            get {
                return players.Count < 2;
            } 
        }

        public Game(List<Hero> players)
        {
            this.players = players;
        }

        /// <summary>
        /// Következő kör
        /// </summary>
        public void NextRound()
        {
            Hero attacker = players.Pick();
            Hero defender = players.Pick();
            OthersRest(players);
            attacker.Attack(defender);
            SurvivorBack(attacker);
            SurvivorBack(defender);
            CleaningUp();
        }

        /// <summary>
        /// Nyertes kihirdetése
        /// </summary>
        public void Winner()
        {
            if (players.Count == 1)
            {
                var winner = players.First();
                Console.WriteLine($"[{winner.Id}] {winner.GetType().Name} Win!");
            }
            if(players.Count < 1)
            {
                Console.WriteLine("Everybody died :(");
            }
        }

        /// <summary>
        /// Aki túlélte az csatát visszakerül a pakliba
        /// </summary>
        /// <param name="hero">Vizsgált hős</param>
        private void SurvivorBack(Hero hero)
        {
            if (hero.IsAlive) {
                players.Add(hero);
            }
        }

        /// <summary>
        /// Hullák eltávolítása a pakliból
        /// </summary>
        private void CleaningUp()
        {
            players.RemoveAll(p => !p.IsAlive);
        }

        /// <summary>
        /// Akik nem vesznek részt csatában rengenerálódnak
        /// </summary>
        /// <param name="players">Pihenő hősök</param>
        private void OthersRest(List<Hero> players)
        {
            players.ForEach(p =>
            {
                p.Rest();
            });
        }
    }
}
