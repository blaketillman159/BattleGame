using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    /// <summary>
    /// Kardos
    /// </summary>
    public class Swordsman : Hero
    {
        public Swordsman()
        {
            Health = 120;
            MaxHealt = 120;
        }
        public override void Attack(Hero opponent)
        {
            base.Attack(opponent);
            if (opponent is Swordsman)
            {
                opponent.Die();
            }
            if (opponent is Bowman)
            {
                opponent.Die();
            }
        }
    }
}
