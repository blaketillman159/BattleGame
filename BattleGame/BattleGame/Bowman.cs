using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    /// <summary>
    /// Íjász
    /// </summary>
    public class Bowman : Hero
    {
        public Bowman()
        {
            Health = 100;
            MaxHealt = 100;
        }

        public override void Attack(Hero opponent)
        {
            base.Attack(opponent);
            if (opponent is Rider)
            {
                var probabillity = new Random().Next(100);
                if(probabillity <= 40)
                {
                    opponent.Die();
                }

            }
            if (opponent is Swordsman) {
                opponent.Die();
            }
            if(opponent is Bowman)
            {
                opponent.Die();
            }
        }
    }
}
