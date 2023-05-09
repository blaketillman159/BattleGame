using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    /// <summary>
    /// Lovas
    /// </summary>
    public class Rider : Hero
    {
        public Rider()
        {
            Health = 150;
            MaxHealt = 150;
        }
        public override void Attack(Hero opponent)
        {
            base.Attack(opponent);
            if (opponent is Rider)
            {
                opponent.Die();
            }
            if (opponent is Swordsman)
            {
                this.Die();
            }
            if (opponent is Bowman)
            {
                opponent.Die();
            }
        }
    }
}
